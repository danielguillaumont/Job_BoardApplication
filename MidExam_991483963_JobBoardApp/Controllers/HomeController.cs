using Microsoft.AspNetCore.Mvc;
using MidExam_991483963_JobBoardApp.Models;

namespace MidExam_991483963_JobBoardApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.JobPostings);
        }

        [HttpGet]
        public IActionResult ApplyForm(int id)
        {
            var job = Repository.GetJobById(id);

            ViewBag.JobTitle = job != null ? job.JobTitle : "";
            ViewBag.JobId = id;

            return View(new Applicant());
        }

        // POST to /Home/ApplyForm/2 
        [HttpPost]
        [Route("Home/ApplyForm/{id}")]
        public IActionResult ApplyForm(int id, Applicant applicant)
        {
            var job = Repository.GetJobById(id);

            ViewBag.JobTitle = job != null ? job.JobTitle : "";
            ViewBag.JobId = id;

            // DEBUG: print validation errors to Output window
            if (!ModelState.IsValid)
            {
                foreach (var entry in ModelState)
                {
                    foreach (var err in entry.Value.Errors)
                    {
                        Console.WriteLine($"{entry.Key}: {err.ErrorMessage}");
                    }
                }

                return View(applicant);
            }

            Repository.AddApplication(id, applicant);

            TempData["Msg"] = "Application submitted!";
            return RedirectToAction("Index");
        }

        public IActionResult CheckStatus()
        {
            return View();
        }

        public IActionResult Search(string email)
        {
            List<string> titles = new List<string>();

            if (!string.IsNullOrWhiteSpace(email))
            {
                foreach (var jobPosting in Repository.JobPostings)
                {
                    if (jobPosting.Applications.Any(a => a.Email == email))
                    {
                        titles.Add(jobPosting.JobTitle);
                    }
                }
            }

            ViewBag.Email = email;
            return View("CheckStatus", titles);
        }
    }
}
