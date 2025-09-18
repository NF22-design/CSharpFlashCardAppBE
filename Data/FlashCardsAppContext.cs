using System;
using FlashCardsAppBE.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsAppBE.Data;

public class FlashCardsAppContext(DbContextOptions<FlashCardsAppContext> options) : DbContext(options)
{
    public DbSet<Genre> Genres => Set<Genre>();
    public DbSet<Deck> Decks => Set<Deck>();
    public DbSet<Card> Cards => Set<Card>();
}
