using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Cards;

public record class CardDetailsDTO(
    int Id,
    [Required] int DeckId,
    string FrontText,
    string FrontImageLink,
    string BackText,
    string BackImageLink,
    bool IsFlipped
);
