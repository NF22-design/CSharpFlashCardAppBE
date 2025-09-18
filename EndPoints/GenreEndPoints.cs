using System;
using FlashCardsAppBE.Data;
using FlashCardsAppBE.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsAppBE.EndPoints;

public static class GenreEndPoints
{
    const string GetGenresEndPoint = "GetGenres";
    const string GetGenreEndPoint = "GetGenre";
    const string PostGenreEndPoint = "CreateGenre";
    const string PutGenreEndPoint = "UpdateGenre";
    const string DeleteGenreEndPoint = "DestroyGenre";

    public static RouteGroupBuilder MapGenres(this WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("genres");
        group.MapGet("/", async (FlashCardsAppContext dbContext) =>
        {
            return await dbContext.Genres.AsNoTracking().ToListAsync();
        }).WithName(GetGenresEndPoint);
        group.MapGet("/{id}", async (int id, FlashCardsAppContext dbContext) =>
        {
            Genre? genre = await dbContext.Genres.FindAsync(id);
        }).WithName(GetGenreEndPoint);
        group.MapPost("/", () =>
        {
            
        }).WithName(PostGenreEndPoint);
        group.MapPut("/{id}", (int id) =>
        {
            
        }).WithName(PutGenreEndPoint);
        group.MapDelete("/{id}", (int id) =>
        {
            
        }).WithName(DeleteGenreEndPoint);
        return group;
    }
}
