using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AniTrakController : ControllerBase
{
    private readonly ILogger<AniTrakController> _logger;
    private AniTrakContext _context;
    
    public  AniTrakController(ILogger<AniTrakController> logger, AniTrakContext aniTrakContext)
    {
        _logger = logger;
        _context = aniTrakContext;
    }

    [HttpGet("All")]
    public async Task<List<MediaType>?> GetAllRecordsTest()
    {
        try
        {
            Console.WriteLine("Getting all media types from database");
            return await _context.MediaTypes.ToListAsync();
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    #region Read Routes

    [HttpGet("Anime/All")]
    public async Task<List<Anime>?> GetAllAnime()
    {
        try
        {
            return await _context.Animes.ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("Error AniTrakController | GetAllAnime " + ex.Message);
            return null;
        }
    }

    [HttpGet("Anime/{id}")]
    public async Task<Anime?> GetAnimeById(int id)
    {
        try
        {
            return await _context.Animes.Where(t => t.AnimeId == id).FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("Error AniTrakController | GetAllAnime " + ex.Message);
            return null;
        }
    }


    #endregion


    #region Write Routes

    #endregion



    #region Destroy Routes
    #endregion


}