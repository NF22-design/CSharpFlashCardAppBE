using System;
using FlashCardsAppBE.DTOs.Decks;
using FlashCardsAppBE.Entities;

namespace FlashCardsAppBE.Mappings;

public static class DeckMapping
{
    public static Deck ToEntity(this CreateDeckDTO createDeckDTO)
    {
        return new()
        {
            Title = createDeckDTO.Title,
            GenreId = createDeckDTO.GenreId,
            NumberOfCards = createDeckDTO.NumberOfCards,
            FlippedCards = createDeckDTO.FlippedCards,
            CreationDate = createDeckDTO.CreationDate
        };
    }
    public static Deck ToEntity(this UpdateDeckDTO updateDeckDTO, int id)
    {
        return new()
        {
            Id = id,
            Title = updateDeckDTO.Title,
            GenreId = updateDeckDTO.GenreId,
            NumberOfCards = updateDeckDTO.NumberOfCards,
            FlippedCards = updateDeckDTO.FlippedCards,
            CreationDate = updateDeckDTO.CreationDate
        };
    }
    public static DeckDetailsDTO ToDeckDetailsDTO(this Deck deck)
    {
        return new(
            deck.Id,
            deck.Title,
            deck.GenreId,
            deck.NumberOfCards,
            deck.FlippedCards,
            deck.CreationDate
        );
    }
    public static DeckDTO ToDeckDTO(this Deck deck)
    {
        return new(
            deck.Id,
            deck.Title,
            deck.Genre!.Name,
            deck.NumberOfCards,
            deck.FlippedCards,
            deck.CreationDate
        );
    }
}
