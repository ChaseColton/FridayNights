using IfpaHosted.Server.Services;



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/ifpa/rankings", () =>
{
    return Results.Ok(new[]
    {
        new { Rank = 1, Player = "Alice", Points = 1200 },
        new { Rank = 2, Player = "Bob", Points = 1100 }
    });
});

app.Run();





//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddHttpClient<IfpaService>();

//builder.Services.AddControllers();
//builder.Services.AddHttpClient();




//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(policy =>
//    {
//        policy.AllowAnyOrigin()
//                      .AllowAnyHeader()
//                      .AllowAnyMethod();
//    });
//});


//var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseCors();
//app.MapControllers();
//app.MapFallbackToFile("index.html");

//app.Run();
