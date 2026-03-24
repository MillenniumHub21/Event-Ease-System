using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_Ease_System.Pages
{
    public class BookingModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string emailAddress = "";
        public string phoneNumber = "";
        public string bookingDate = "";
        public string message = "";
       
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            hasData = true;
            firstName = Request.Form["firstname"];
            lastName = Request.Form["lastname"];
            emailAddress = Request.Form["emailaddress"];
            phoneNumber = Request.Form["phonenumber"];
            bookingDate = Request.Form["bookingdate"];
            message = Request.Form["subject"];
        }
    }
}
