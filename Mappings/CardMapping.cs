using System;
using FlashCardsAppBE.DTOs.Cards;
using FlashCardsAppBE.Entities;

namespace FlashCardsAppBE.Mappings;

public static class CardMapping
{
    public static Card ToEntity(this CreateCardDTO createCardDTO)
    {
        return new()
        {
            DeckId = createCardDTO.DeckId,
            FrontText = createCardDTO.FrontText,
            FrontImageLink = createCardDTO.FrontImageLink,
            BackText = createCardDTO.BackText,
            BackImageLink = createCardDTO.BackImageLink,
            IsFlipped = createCardDTO.IsFlipped
        };
    }
    public static Card ToEntity(this UpdateCardDTO updateCardDTO, int id)
    {
        return new()
        {
            Id = id,
            DeckId = updateCardDTO.DeckId,
            FrontText = updateCardDTO.FrontText,
            FrontImageLink = updateCardDTO.FrontImageLink,
            BackText = updateCardDTO.BackText,
            BackImageLink = updateCardDTO.BackImageLink,
            IsFlipped = updateCardDTO.IsFlipped
        };
    }
    public static CardDetailsDTO ToCardDetailsDTO(this Card card)
    {
        return new(
            card.Id,
            card.DeckId,
            card.FrontText!,
            card.FrontImageLink!,
            card.BackText!,
            card.BackImageLink!,
            card.IsFlipped
        );
    }
    public static CardDTO ToCardDTO(this Card card)
    {
        return new(
            card.Id,
            card.Deck!.Title,
            card.FrontText!,
            card.FrontImageLink!,
            card.BackText!,
            card.BackImageLink!,
            card.IsFlipped
        );
    }
}
