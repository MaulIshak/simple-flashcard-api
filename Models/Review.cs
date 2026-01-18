using System;

namespace SimpleFlashCardApi.Models;

public class Review
{
    public int Id { get; set; }
    public double Score {get; set;}
    public string? Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public required User User { get; set; }
}
