using System.ComponentModel.DataAnnotations;

public class NewsItem
{
    [Key]    
    public Guid Guid { get; set; }
    public string Link { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? ImageUrl { get; set; }
    // Add other properties as needed
}

