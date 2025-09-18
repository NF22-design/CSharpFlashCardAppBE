using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Decks;

public record class DeckDetailsDTO(
    int Id,
    [Required][StringLength(45)] string Title,
    [Required] int GenreId,
    int NumberOfCards,
    int FlippedCards,
    DateOnly CreationDate
);