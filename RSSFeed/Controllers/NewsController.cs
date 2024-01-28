using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Xml.Linq;

namespace RSSFeed.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsDbContext _dbContext;

        public NewsController(NewsDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            var newsItems = _dbContext.NewsItems.ToList(); // Assuming _dbContext is your database context
            return View(newsItems);
        }


        [HttpPost]
        public IActionResult ClearAndSeedFromXml()
        {
            try
            {
              
                    // Clear existing data from the table
                    _dbContext.NewsItems.RemoveRange(_dbContext.NewsItems);
                    _dbContext.SaveChanges();
                
               

                // Read and seed data from XML
                var rssFeedPath = "C:\\Users\\dimip\\Desktop\\newsfeed.xml"; // Replace with the actual path
                var newsItems = ReadRssFeed(rssFeedPath);

                

                _dbContext.NewsItems.AddRange(newsItems);
                _dbContext.SaveChanges();

                TempData["SuccessMessage"] = "Database updated successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while updating the database.";
                // Log the exception, if needed
            }

            return RedirectToAction(nameof(Index));
        }

        internal List<NewsItem> ReadRssFeed(string rssFeedPath)
        {
            var newsItems = new List<NewsItem>();

            try
            {
                var xmlDoc = XDocument.Load(rssFeedPath);

                foreach (var item in xmlDoc.Descendants("item"))
                {
                    Guid guid = Guid.NewGuid();
                    var link = item.Element("link")?.Value;
                    var title = item.Element("title")?.Value;
                    var description = item.Element("description")?.Value;
                    var imageUrl = item.Element("enclosure")?.Attribute("url")?.Value;

                    if (!string.IsNullOrEmpty(link) && !string.IsNullOrEmpty(title))
                    {
                        var newsItem = new NewsItem
                        {
                            Guid = guid,
                            Link = link,
                            Title = title,
                            Description = description,
                            ImageUrl = imageUrl
                            // Add other properties as needed
                        };

                        newsItems.Add(newsItem);
                    }
                    else
                    {
                        // Log or handle the case where the GUID cannot be parsed
                    }
                }

            
            }
            catch
            {
                // Handle exceptions
            }

            return newsItems;
        }
    }
}
