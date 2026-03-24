using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;

namespace Event_Ease_System.Pages
{
    public class EventModel : PageModel
    {
        public bool hasData = false;
        public string eventType = "";
        public string eventDate = "";
        public string eventDescription = "";
        public string eventVenue = "";
        public string message = "";
    
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            hasData = true;
            eventType = Request.Form["eventtype"];
            eventDate = Request.Form["eventdate"];
            eventDescription = Request.Form["eventdescription"];
            eventVenue = Request.Form["eventvenue"];
            message = Request.Form["subject"];
        }
    }
}
