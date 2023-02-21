using System.Net.Http.Headers;
using System.Text.Json;


using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessApiAsync(client);

static async Task ProcessApiAsync(HttpClient client)
{
    var json =
        await client.GetStringAsync("https://www3.septa.org/api/TransitView/index.php/47");
    Console.Write(json);

    return;
}

