using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpiderFan2.Pages
{
    public class IndexModel : PageModel
    {
        public List<SocialMediaProfile> SocialMediaProfiles { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // You can fetch real data using API calls for each platform here.
            // Placeholder data for now.
            SocialMediaProfiles = new List<SocialMediaProfile>
        {
            new SocialMediaProfile
            {
                Platform = "Youtube",
                FollowerCount = "396K",
                Url = "https://www.youtube.com/spiderman",
                IconClass = "fa-youtube",
                ImageUrl = "/images/spiderman-youtube.jpg"
            },
            new SocialMediaProfile
            {
                Platform = "Instagram",
                FollowerCount = "3.3M",
                Url = "https://www.instagram.com/spiderman/",
                IconClass = "fa-instagram",
                ImageUrl = "/images/spiderman-instagram.jpg"
            },
            new SocialMediaProfile
            {
                Platform = "Twitter",
                FollowerCount = "2.8M",
                Url = "https://twitter.com/spiderman",
                IconClass = "fa-twitter",
                ImageUrl = "/images/spiderman-twitter.jpg"
            },
            new SocialMediaProfile
            {
                Platform = "Facebook",
                FollowerCount = "703K",
                Url = "https://www.facebook.com/spiderman/",
                IconClass = "fa-facebook",
                ImageUrl = "/images/spiderman-facebook.jpg"
            }
            // Add more profiles as needed
        };
        }
    }

    public class SocialMediaProfile
    {
        public string Platform { get; set; }
        public string FollowerCount { get; set; }
        public string Url { get; set; }
        public string IconClass { get; set; }
        public string ImageUrl { get; set; }
    }
}
