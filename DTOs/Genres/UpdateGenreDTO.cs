using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Genres;

public record class UpdateGenreDTO(
    [Required][StringLength(45)] string Name
);
