using System;

namespace FlashCardsAppBE.Entities;

public class Card
{
    public int Id { get; set; }
    public int DeckId { get; set; }
    public Deck? Deck { get; set; }
    public string? FrontText { get; set; }
    public string? FrontImageLink { get; set; }
    public string? BackText { get; set; }
    public string? BackImageLink { get; set; }
    public bool IsFlipped { get; set; }
}
