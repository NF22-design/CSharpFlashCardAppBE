using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Decks;

public record class CreateDeckDTO(
    [Required][StringLength(45)] string Title,
    [Required] int GenreId,
    int NumberOfCards,
    int FlippedCards,
    DateOnly CreationDate
);
