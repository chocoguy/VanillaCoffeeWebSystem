using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;
using Business.DbAniTrakModels;
using Npgsql;
using WebApi.DatabaseServices;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AniTrakController : ControllerBase
{
    private readonly ILogger<AniTrakController> _logger;
    private AniTrakDbService _dbService;
    
    public  AniTrakController(ILogger<AniTrakController> logger, NpgsqlDataSource dataSource)
    {
        _logger = logger;
        _dbService = new AniTrakDbService(dataSource);
    }

    [HttpGet("All")]
    public async Task<List<Anime>?> GetAllAnime()
    {
        try
        {
            Console.WriteLine("Getting all anime from database");
            return await _dbService.GetAllAnime();
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    
}