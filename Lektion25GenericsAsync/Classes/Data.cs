using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace Lektion25GenericsAsync.Classes;

public class Data
{
    private HttpClient HttpClient { get; }

    public Data(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<List<Dog>> Get()
    {
        await Task.Delay(3000); // Fejka anrop över HTTP/S
        var result = await HttpClient.GetFromJsonAsync<List<Dog>>(
            "sample-data/dogs.json");
        // Använda datat
        return result?.ToList() ?? new List<Dog>();
    }
}
