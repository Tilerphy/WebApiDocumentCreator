using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiDocumentCreator
{
    public class TemplateCompiler
    {
        private  Stack<char> _s = new Stack<char>();
        private List<Queue<char>> _qs = new List<Queue<char>>();
        private  StringBuilder _result = new StringBuilder();
        public  string CompileWithTemplate(string template, Dictionary<string, object> paramVals)
        {

            foreach (char c in template)
            {
                CharStatus cStatus = CheckChar(c);
                int l = _s.Count;
                switch (cStatus.Status)
                {
                    case StatckStatus.Translate:
                        char end = _s.Pop();
                        _s.Clear();
                        _qs[l].Enqueue(end);
                        break;
                    case StatckStatus.Normal:
                        _result.Append(c);
                        break;
                    case StatckStatus.Start:
                        _s.Push(c);
                        CreateAndEnqueue(c);
                        break;
                    case StatckStatus.Inner:
                        _qs[l - 1].Enqueue(c);
                        break;
                    case StatckStatus.End:
                        _qs[l - 1].Enqueue(c);
                        string key = cStatus.Key.Trim('(', ')');
                        if (paramVals.ContainsKey(key))
                        {
                            _result.Append(Newtonsoft.Json.JsonConvert.SerializeObject(paramVals[key]));
                        }
                        else
                        {
                            _result.Append("");
                        }

                        _s.Clear();
                        _qs.Clear();
                        break;
                    
                }
            }
            return _result.ToString();
        }

        private CharStatus CheckChar(char c)
        {
            int l = _s.Count;
            switch (c)
            {
                case '(':
                    return new CharStatus { Status = StatckStatus.Start };
                case ')':

                    if (l != 1)
                    {

                        return new CharStatus
                        {
                            Status = StatckStatus.Translate
                        };
                    }
                    else
                    {
                        return new CharStatus
                        {
                            Key =  string.Join("",_qs[l - 1].ToArray()),
                            Status = StatckStatus.End,
                            Level = l - 1
                        };
                    }


                default:

                    return new CharStatus { Status = l == 0 ? StatckStatus.Normal : StatckStatus.Inner };
            }
        }

        private Queue<char> CreateAndEnqueue(char c)
        {
            Queue<char> q = new Queue<char>();
            _qs.Add(q);
            Enqueue(c);
            return q;
        }

        private int Enqueue(char c)
        {
            _qs[_s.Count - 1].Enqueue(c);
            return _s.Count;
        }
    }

    public class CharStatus
    {
        public string Key { get; set; }
        public int Level { get; set; }
        public StatckStatus Status { get; set; }
    }
    public enum StatckStatus
    {
        Translate = 0,
        Start =1,
        Normal = 2,
        End = 3,
        Inner =4
    }
}
