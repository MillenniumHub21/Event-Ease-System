using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Event_Ease_System.Pages
{
    public class VenueModel : PageModel
    {
        public bool hasData = false;
        public string venueName = "";
        public string venueLocation = "";
        public string venueCapacity = "";
        public void OnGet()
        {
        }
        public void OnPost() 
        {
            hasData = true;
            venueName = Request.Form["venuename"];
            venueLocation = Request.Form["venuelocation"];
            venueCapacity = Request.Form["venuecapacity"];
        }
    }
}
