namespace SimpleFlashCardApi.Models;

public class Deck
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsPublished { get; set; }
    public DateTime PublishedAt {get; set;}

}
