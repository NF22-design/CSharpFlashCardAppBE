using System.ComponentModel.DataAnnotations;

namespace FlashCardsAppBE.DTOs.Genres;

public record class CreateGenreDTO(
    [Required][StringLength(45)] string Name
);
