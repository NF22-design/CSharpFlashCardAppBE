using System;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsAppBE.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<FlashCardsAppContext>();
        await dbContext.Database.MigrateAsync();
    }
}
