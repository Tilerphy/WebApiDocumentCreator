using System;
using System.Collections.Generic;
using System.Text;
using Fiddler;
using System.IO;
using System.Windows.Forms;
using WebApiDocumentCreator;

[assembly:Fiddler.RequiredVersion("4.6.2.0")]
public class Entry : Fiddler.IFiddlerExtension
{
    //private static Dictionary<int, Session> _sessions = new Dictionary<int, Session>();
    protected Page page { get; set; }
    public void OnBeforeUnload()
    {


    }

    public void OnLoad()
    {
        page = new Page();
        
        var b = new Button();
        b.Text = "Export";
        b.Click += ExportButtonClicked;
        page.browse.Click += Browse_Click;
        page.useTemplate.CheckedChanged += UseTemplate_CheckedChanged;
        page.Controls.Add(b);
        page.Dock = DockStyle.Fill;
        var tab = new TabPage();
        tab.Text ="WebApi";
        tab.Controls.Add(page);
        FiddlerApplication.UI.tabsViews.TabPages.Add(tab);


    }

    protected void UseTemplate_CheckedChanged(object sender, EventArgs e)
    {

        page.outputTemplate.Enabled = (sender as CheckBox).Checked;

    }

    protected virtual void Browse_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog d = new FolderBrowserDialog();
        DialogResult dr = d.ShowDialog();
        
        switch (dr)
        {
            case DialogResult.OK:
            case DialogResult.Yes:
                this.page.exportTo.Text = d.SelectedPath;
                break;
            default:
                break;
        }
        d.Dispose();
    }

    protected virtual void ExportButtonClicked(object sender, EventArgs e)
    {
        Session[] sessions = FiddlerApplication.UI.GetSelectedSessions();
        PopToFile(sessions);
        
    }


    private void PopToFile(Session[] sessions)
    {
        lock (FiddlerApplication.UI)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(page.exportTo.Text, true))
                {
                    foreach (Session s in sessions)
                    {
                        sw.WriteLine(GetLine(s));
                    }

                }
                MessageBox.Show("Completed.");
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Failed: {0}", e.ToString()));
            }

        }
    }


    /// <summary>
    /// Url Method  ContentType RequestData RequestHeader  ResponseData ResponseHeader StatusCode
    /// RequestHeader:<headerName> ResponseHeaders:<headerName>
    /// 
    /// Example:
    /// {url:(Url), status:(StatusCode), refer:(ResponseHeaders:Refer)}
    /// </summary>
    /// <param name="session"></param>
    /// <returns></returns>

    protected virtual string GetLine(Session session)
    {
        Dictionary<string, object> item = new Dictionary<string, object>();
        item.Add("Url",  session.fullUrl );
        if (page.hasMethod.Checked)
        {
            item.Add("Method",  session.RequestMethod );
        }

        if (page.hasContentType.Checked)
        {
            item.Add("ContentType", session.RequestHeaders["Content-Type"] );
        }

        if (page.hasRequestData.Checked)
        {
            item.Add("RequestData", Encoding.UTF8.GetString(session.RequestBody) );
        }

        if (page.hasRequestHeader.Checked)
        {
            item.Add("RequestHeader",  session.RequestHeaders.ToString() );
        }
        if (page.hasResponseBody.Checked)
        {
            item.Add("ResponseData",  Encoding.UTF8.GetString(session.ResponseBody) );
        }

        if (page.hasResponseHeader.Checked)
        {
            item.Add("ResponseHeader",  session.ResponseHeaders.ToString() );
        }

        item.Add("StatusCode",  session.responseCode.ToString() );

        foreach (var key in session.RequestHeaders)
        {
            string _key = string.Format("RequestHeaders:{0}", key.Name);
            if (item.ContainsKey(_key))
            {
                if (item[_key] is string)
                {
                    string tmp = item[_key].ToString();
                    item[_key] = new List<string> { tmp, key.Value };
                }
                else if (item[_key] is List<string>)
                {
                    (item[_key] as List<string>).Add(key.Value);
                }
                
            }
            else
            {
                item.Add(_key,  key.Value);
            }
        }

        foreach (var key in session.ResponseHeaders)
        {
            string _key = string.Format("ResponseHeaders:{0}", key.Name);
            if (item.ContainsKey(_key))
            {
                if (item[_key] is string)
                {
                    string tmp = item[_key].ToString();
                    item[_key] = new List<string> { tmp, key.Value };
                }
                else if (item[_key] is List<string>)
                {
                    (item[_key] as List<string>).Add(key.Value);
                }

            }
            else
            {
                item.Add(_key, key.Value);
            }
        }

        return CreateLine(item);

    }

    protected virtual string CreateLine(Dictionary<string, object> items)
    {
        if (page.useTemplate.Checked)
        {
            TemplateCompiler c = new TemplateCompiler();
            return c.CompileWithTemplate(page.outputTemplate.Text, items);
        }
        else
        {
            return string.Format("{0}{1}", Newtonsoft.Json.JsonConvert.SerializeObject(items), Environment.NewLine);
        }
    }
}

