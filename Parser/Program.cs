using Newtonsoft.Json.Linq;
namespace Parser
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string net = "https://www.cbr-xml-daily.ru/daily_json.js";
            var response = await client.GetStringAsync(net);
            JObject json = JObject.Parse(response);
            var valute = json["Valute"]["GEL"];
            Console.WriteLine(valute["Name"]);
            Console.WriteLine(valute["Value"]);
            //foreach (var i in json["Valute"].Values()) {
            //Console.WriteLine(i.ToString());
            //}
    }
}
}
