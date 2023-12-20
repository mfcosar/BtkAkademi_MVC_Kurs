
using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;



namespace BtkAkademi.Controllers

{
    public class CourseController: Controller
    {
        public IActionResult Index() {

            var model = Repository.Applications;
            
            return View(model); }

        public IActionResult Apply()
        { // get ile çalışır

            return View();
        }

        //post ile çalışmasını istiyorsak
        [HttpPost]
        [ValidateAntiForgeryToken] //güvenli data almak için
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is an application for you");


            }
            if (ModelState.IsValid) { 
                Repository.Add(model);
                return View("Feedback", model);
            }
            else return View();
        }

    }
}

