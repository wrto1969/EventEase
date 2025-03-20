namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string? EventName { get; set; }
    public string? Location { get; set; }
}
