using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Cards;

public record class CreateCardDTO(
    [Required] int DeckId,
    string FrontText,
    string FrontImageLink,
    string BackText,
    string BackImageLink,
    bool IsFlipped
);