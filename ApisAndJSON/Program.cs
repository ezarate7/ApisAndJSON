using Newtonsoft.Json.Linq;



var client = new HttpClient();


for (int i = 0; i < 5; i++)
{

    
    var kanyeURL = "https://api.kanye.rest/";
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    Console.WriteLine($"Kanye: {kanyeQuote}");
        

    
    var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    var ronResponse = client.GetStringAsync(ronURL).Result;
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    Console.WriteLine($"Ron: {ronQuote}");
}