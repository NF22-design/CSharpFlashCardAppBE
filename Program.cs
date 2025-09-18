using FlashCardsAppBE.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string? ConnectionString = builder.Configuration.GetConnectionString("FlashCardsApp");
MySqlServerVersion serverVersion = new(new Version(8, 0, 43));
builder.Services.AddDbContext<FlashCardsAppContext>(
    dbContextOptions => dbContextOptions.UseMySql(ConnectionString, serverVersion)
);

var app = builder.Build();
await app.MigrateDbAsync();
app.Run();
