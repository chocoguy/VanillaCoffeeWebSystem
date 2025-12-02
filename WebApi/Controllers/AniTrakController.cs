using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Helpers;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using WebApi.Services;
using Business.Models;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AniTrakController : ControllerBase
{
    private readonly ILogger<AniTrakController> _logger;
    private AniTrakContext _context;
    private ControllerHelpers _controllerHelpers;
    private MalService _malService;

    public  AniTrakController(ILogger<AniTrakController> logger, AniTrakContext aniTrakContext, MalService malService)
    {
        _logger = logger;
        _context = aniTrakContext;
        _controllerHelpers = new ControllerHelpers();
        _malService = malService;
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

    [HttpPost("Anime/Search")]
    public async Task<List<Anime>?> SearchDbAnime()
    {
        try
        {
            List<Anime> searchResults = new();
            string searchQuery = await _controllerHelpers.GetTextFromBodyReq(Request);
            foreach (Anime a in _context.Animes.Where(t => t.Title.Contains(searchQuery)))
            {
                searchResults.Add(a);
            }
            return searchResults;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("Error AniTrakController | SearchDbAnime " + ex.Message);
            return null;
        }
    }

    [HttpPost("Anime/Search/Mal")]
    public async Task<List<Anime>?> SearchMalAnime([FromQuery(Name = "limit")] int limit)
    {
        try
        {
            string searchQuery = await _controllerHelpers.GetTextFromBodyReq(Request);
            MALSearch? malSearchRes = await _malService.QueryMalAnime(searchQuery, limit);

            if(malSearchRes != null)
            {

            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            _logger.LogError("Error AniTrakController | SearcgMalAnime " + ex.Message);
            return null;
        }
    }


    #endregion


    #region Write Routes

    #endregion



    #region Destroy Routes
    #endregion


}