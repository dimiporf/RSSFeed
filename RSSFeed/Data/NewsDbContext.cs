using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

public class NewsDbContext : DbContext
{
    public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options)
    {
    }

    public DbSet<NewsItem> NewsItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     
       modelBuilder.Entity<NewsItem>().HasData(
                new NewsItem
                {
                    Guid = Guid.NewGuid(),
                    Link = "https://example.com",
                    Title = "Dummy News 1",
                    Description = "This is a dummy news entry 1",
                    ImageUrl = "https://example.com/image1.jpg"
                },
                new NewsItem
                {
                    Guid= Guid.NewGuid(),
                    Link = "https://example.com",
                    Title = "Dummy News 2",
                    Description = "This is a dummy news entry 2",
                    ImageUrl = "https://example.com/image2.jpg"
                });
        //other configurations...

        base.OnModelCreating(modelBuilder);
    }
    //public void ClearAndSeedFromXml(string rssFeedPath)
    //{
    //    // Clear existing entries
    //    NewsItems.RemoveRange(NewsItems);
    //    SaveChanges();

    //    // Seed with new data from XML
    //    var newsItems = ReadRssFeed(rssFeedPath);
    //    NewsItems.AddRange(newsItems);
    //    SaveChanges();
    //}
    //private List<NewsItem> ReadRssFeed(string rssFeedPath)
    //{
    //    var newsItems = new List<NewsItem>();

    //    try
    //    {
    //        var xmlDoc = XDocument.Load(rssFeedPath);

    //        foreach (var item in xmlDoc.Descendants("item"))
    //        {
    //            var title = item.Element("title")?.Value;
    //            var link = item.Element("link")?.Value;
    //            var description = item.Element("description")?.Value;
    //            var imageUrl = item.Element("imageUrl")?.Value;
                

    //            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(link))
    //            {
    //                var newsItem = new NewsItem
    //                {
    //                    Title = title,
    //                    Link = link,
    //                    Description = description,
    //                    ImageUrl = imageUrl
                        
    //                    // You can add more properties based on your XML structure
    //                };

    //                newsItems.Add(newsItem);
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // Handle the exception (log, display an error message, etc.)
    //        // For simplicity, we are not handling exceptions thoroughly in this example
    //    }

    //    return newsItems;
    //}
}
