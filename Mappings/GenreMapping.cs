using System;
using FlashCardsAppBE.DTOs.Genres;
using FlashCardsAppBE.Entities;

namespace FlashCardsAppBE.Mappings;

public static class GenreMapping
{
    public static GenreDTO ToGenreDTO(this Genre genre)
    {
        return new(
            genre.Id,
            genre.Name
        );
    }
    public static Genre ToEntity(this GenreDTO genreDTO)
    {
        return new()
        {
            Id = genreDTO.Id,
            Name = genreDTO.Name
        };
    }
    public static Genre ToEntity(this CreateGenreDTO createGenreDTO)
    {
        return new()
        {
            Name = createGenreDTO.Name
        };
    }
    public static Genre ToEntity(this UpdateGenreDTO updateGenreDTO, int id)
    {
        return new()
        {
            Id = id,
            Name = updateGenreDTO.Name
        };
    }
}