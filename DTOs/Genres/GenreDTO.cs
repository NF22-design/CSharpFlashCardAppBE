using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Genres;

public record class GenreDTO(
    int Id,
    [Required][StringLength(45)] string Name
);
