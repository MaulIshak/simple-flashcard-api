using System;

namespace SimpleFlashCardApi.Models;

public class Card
{
    public int Id { get; set; }
    public required string Front { get; set; }
    public required string Back { get; set; }
}
