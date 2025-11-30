using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.HttpOverrides;
using Npgsql;
using WebApi.Helpers;

var builder = WebApplication.CreateBuilder(args);
var malApiKey = builder.Configuration["MalClientId"];
var webSystemVersion = builder.Configuration["WebSystemVersion"];

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddHttpClient(
    "MalClient",
    client =>
    {client.BaseAddress = new Uri("https://api.myanimelist.net/v2/"); client.DefaultRequestHeaders.Add("X-MAL-CLIENT-ID", malApiKey);}
);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.Configure<PostgresDb>(builder.Configuration.GetSection("Postgres"));

var dataSourceBuilder = new NpgsqlDataSourceBuilder(connString);


var dataSource = dataSourceBuilder.Build();


dataSource = dataSource.

builder.Services.AddSingleton<NpgsqlDataSource>(dataSource);


var app = builder.Build();

app.UseCors("AllowAll");
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/", () => Results.Ok("Vanilla Coffee Web System (VCWS). Version: " + webSystemVersion));



app.Run();
