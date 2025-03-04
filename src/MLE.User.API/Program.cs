using MLE.User.Application;
using MLE.User.Persistence;
using MLE.User.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    await scope.ServiceProvider
        .GetRequiredService<UserDbContext>()
        .DatabaseMigrator();
    var userSeeder = scope.ServiceProvider.GetRequiredService<UserSeeder>();
    await userSeeder.SeedData();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}