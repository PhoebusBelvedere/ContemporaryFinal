using ContemporaryFinal
using Microsoft.EntityFrameworkCore;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.ContemporaryFinalDbContext<DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "ContemporaryFinal API";
    
});

var app = builder.Build();

//Apply EF Core migrations automatically 
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();     
    SeedData.Initialize(db);   
}

//Enable NSwag UI
app.UseOpenApi();
app.UseSwaggerUi3();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
