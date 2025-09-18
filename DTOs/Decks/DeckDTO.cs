using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Decks;

public record class DeckDTO(
    int Id,
    [Required][StringLength(45)] string Title,
    [Required] string Genre,
    int NumberOfCards,
    int FlippedCards,
    DateOnly CreationDate
);