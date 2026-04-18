using BlazorApp.Shared;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Net.Http.Json;

namespace IfpaHosted.Server.Services;

public class IfpaService
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;

    public IfpaService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _config = config;
        _http.BaseAddress = new Uri("https://api.ifpapinball.com/v1/");
    }

    public async Task<List<IfpaPlayerRanking>> GetRankings()
    {
        var apiKey = _config["Ifpa:ApiKey"];
        apiKey = "abf861c4dacac66afacec487376ca3ed";
        var response =
            await _http.GetFromJsonAsync<IfpaRankingsResponse>(
                $"rankings?api_key={apiKey}&items_per_page=50");

        return response?.Rankings ?? [];
    }
}
