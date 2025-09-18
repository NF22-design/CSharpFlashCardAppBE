using System;
using FlashCardsAppBE.Data;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsAppBE.EndPoints;

public static class CardEndPoints
{
    const string GetCardsEndPoint = "GetCards";
    const string GetCardEndPoint = "GetCard";
    const string PostCardEndPoint = "CreateCard";
    const string PutCardEndPoint = "UpdateCard";
    const string DeleteCardEndPoint = "DestroyCard";

    public static RouteGroupBuilder MapCards(this WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("cards");
        group.MapGet("/", async (FlashCardsAppContext dbContext) =>
        {
            return await dbContext.Cards.AsNoTracking().ToListAsync();
        }).WithName(GetCardsEndPoint);
        group.MapGet("/{id}", (int id) =>
        {
            
        }).WithName(GetCardEndPoint);
        group.MapPost("/", () =>
        {
            
        }).WithName(PostCardEndPoint);
        group.MapPut("/{id}", (int id) =>
        {
            
        }).WithName(PutCardEndPoint);
        group.MapDelete("/{id}", (int id) =>
        {
            
        }).WithName(DeleteCardEndPoint);
        return group;
    }
}
