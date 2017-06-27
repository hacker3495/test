#r "Newtonsoft.Json"
using System.Net;
using System.Text;
using Newtonsoft.Json;
 
public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, string name, TraceWriter log)
{
    Website data = new Website(); // just a sample object
    data.Name = "CodeHollow";
    data.Url = "https://codehollow.com";
    data.Author = "Armin Reiter";
    data.BlogEntries = 36;
    data.Caller = name;
 
    var json = JsonConvert.SerializeObject(data, Formatting.Indented);
     
    return new HttpResponseMessage(HttpStatusCode.OK) 
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json")
    };
}
 
public class Website
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Author { get; set; }
    public int BlogEntries { get; set; }
    public string Caller { get; set; }
}
