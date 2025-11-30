using Business.DbAniTrakModels;
using Dapper;
using Npgsql;

namespace WebApi.DatabaseServices;

public class AniTrakDbService
{
    private readonly NpgsqlDataSource _dataSource;

    public AniTrakDbService(NpgsqlDataSource dataSource)
    {
        _dataSource = dataSource;
    }
    

    public async Task<List<Anime>> GetAllAnime()
    {
        try
        {
            Console.WriteLine("Getting all anime from database");


            await using var connection = await _dataSource.OpenConnectionAsync();
            string query = "SELECT * FROM anime";
            var QueryResult = await connection.QueryAsync<Anime, Season, MediaType, OriginalSource, AirDay, Anime>(
                query,
                (anime, season, mediaType, originalSource, airDay) =>
                {
                    anime.Season = season;
                    anime.MediaType = mediaType;
                    anime.OriginalSource = originalSource;
                    anime.AirDay = airDay;
                    return anime;
                },
                splitOn: "Id,Id,Id,Id"
            );
            return QueryResult.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
        
    

    
}