using Microsoft.EntityFrameworkCore;
using TrainStationsAPI.Database;
using TrainStationsAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILineService, LineService>();
builder.Services.AddScoped<ITrainStationService, TrainStationService>();

string connectionStr =  builder.Configuration.GetConnectionString("SqliteConnectionString");

// Add services to the container.
builder.Services.AddDbContext<TrainStationsContext>(opt => opt.UseSqlite(connectionStr));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
