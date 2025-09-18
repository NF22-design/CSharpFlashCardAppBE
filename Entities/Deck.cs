using System;

namespace FlashCardsAppBE.Entities;

public class Deck
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    public int NumberOfCards { get; set; }
    public int FlippedCards { get; set; }
    public DateOnly CreationDate { get; set; }
}
