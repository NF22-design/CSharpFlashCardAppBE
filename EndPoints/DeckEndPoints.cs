using System;
using FlashCardsAppBE.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsAppBE.EndPoints;

public static class DeckEndPoints
{
    const string GetDecksEndPoint = "GetDecks";
    const string GetDeckEndPoint = "GetDeck";
    const string PostDeckEndPoint = "CreateDeck";
    const string PutDeckEndPoint = "UpdateDeck";
    const string DeleteDeckEndPoint = "DestroyDeck";

    public static RouteGroupBuilder MapDecks(this WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("decks");
        group.MapGet("/", async (FlashCardsAppContext dbContext) =>
        {
            return await dbContext.Decks.AsNoTracking().ToListAsync();
        }).WithName(GetDecksEndPoint);
        group.MapGet("/{id}", (int id) =>
        {
            
        }).WithName(GetDeckEndPoint);
        group.MapPost("/", () =>
        {
            
        }).WithName(PostDeckEndPoint);
        group.MapPut("/{id}", (int id) =>
        {
            
        }).WithName(PutDeckEndPoint);
        group.MapDelete("/{id}", (int id) =>
        {
            
        }).WithName(DeleteDeckEndPoint);
        return group;
    }
}
