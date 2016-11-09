# WebApiDocumentCreator
A Fiddler 4 extension， use to create a file with format lines from the requests/responses.

<b>Fiddler 4 </b>： https://www.telerik.com/download/fiddler

<h3>Usage</h3>

1. Download the codes, and compile it directly.
(Please goto http://www.telerik.com/fiddler to download the Fiddler4 first.
The reference file is the main entry of Fiddler4, named as Fiddler.exe.)

2. Copy the Compiled result: WebApiDocumentCreator.dll and Newtonsoft.Json.dll into folder %Fiddler install path%/Scripts/.
My Fiddler 4 is installed into C:/Program Files (x86)/Fiddler/, then I need to copy these two dlls into 
C:/Program Files (x86)/Fiddler/Scripts

3. Restart the Fiddler.

4. Select the sessions.

5. Find the Tab named "WebApi" in right panel of Fiddler. Select it.

6. Select the data you want to export. 

7. Select the Export Location. <b>Please remember to write the filename after the folder selection</b>.

8. Then click <b>Export</b>. All selected sessions will be exported into the selected file with Json format. 
<b>One session one line</b>.

9. If you are an advanced user, you can use the <b>Templated Exportor</b>.

<h3>Templated Exportor</h3>

These placeholders can be used:

Url 

Method  

ContentType 

RequestData 

RequestHeader  

ResponseData 

ResponseHeader 

StatusCode

RequestHeader:[headerName]

ResponseHeaders:[headerName]

<b>For example:</b>

template: {url:(Url), setcookie:(ResponseHeaders:Set-Cookie)}

exported line: {url:"http://www.goolge.com", setcookie:["cookie1", "cookie2"]}

<b>Json format template is recommanded, because the Array value is serialized into Json Array.</b>

