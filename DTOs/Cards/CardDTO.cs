using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FlashCardsAppBE.DTOs.Cards;

public record class CardDTO(
    int Id,
    [Required] string DeckTitle,
    string FrontText,
    string FrontImageLink,
    string BackText,
    string BackImageLink,
    bool IsFlipped
);
