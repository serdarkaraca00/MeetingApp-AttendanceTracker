using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller 
    {
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;

            ViewData["Hello"] = saat > 12 ? "Have a good day":"Good morning";
            int UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo() 
            {
                Id = 1,
                Location = "İstanbul, taksim square",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}