using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Cards;

public record class UpdateCardDTO(
    [Required] int DeckId,
    string FrontText,
    string FrontImageLink,
    string BackText,
    string BackImageLink,
    bool IsFlipped
);