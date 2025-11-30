using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.Logging.Abstractions;

namespace WebApi.Services;

public class MalService
{
    private readonly ILogger<MalService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    public MalService(ILogger<MalService> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task<MALAnime?> GetMalAnimeById(int malId)
    {
        try
        {
            var client = _httpClientFactory.CreateClient("MalClient");
            var res = await client.GetAsync(
                $"anime/{malId}?fields=id,title,num_episodes,source,media_type,start_season,broadcast,main_picture,start_date,end_date,synopsis,rank,status,status,studios,mean,statistics,pictures");
            
            return await res.Content.ReadFromJsonAsync<MALAnime>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("MalService.cs | GetAnimeById: " + ex.Message);
            return null;
        }
    }

    public async Task<MALSearch?> GetSeasonalMalAnime(int year, string season, int searchLimit)
    {
        try
        {
            var client = _httpClientFactory.CreateClient("MalClient");
            var res = await client.GetAsync($"anime/{season}/{year}?limit={searchLimit}");
            return await res.Content.ReadFromJsonAsync<MALSearch>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("MalService.cs | GetSeasonalAnime: " + ex.Message);
            return null;
        }
    }

    public async Task<MALSearch?> QueryMalAnime(string searchQuery, int searchLimit)
    {
        try
        {
            var client = _httpClientFactory.CreateClient("MalClient");
            var res = await client.GetAsync($"anime?q={searchQuery}&limit={searchLimit}");
            return await res.Content.ReadFromJsonAsync<MALSearch>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("MalService.cs | QueryMalAnime: " + ex.Message);
            return null;
        }
    }
    
}