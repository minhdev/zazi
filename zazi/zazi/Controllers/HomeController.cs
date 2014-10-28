using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zazi.Models;
using zazi.Services;

namespace zazi.Controllers
{
    public class HomeController : Controller
    {
        private INotebookServices notebookServices;

        public HomeController(INotebookServices notebookServices)
        {
            this.notebookServices = notebookServices;
        }

        // GET: Home
        /// <summary>
        /// Index controller, display greeting and notes
        /// </summary>
        /// <returns>ViewResult of the index</returns>
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                ViewBag.Greeting = "Good morning!";
            }
            else
            {
                ViewBag.Greeting = "Hi there!";
            }
            ViewBag.Entries = notebookServices.GetEntries();

            return View();
        }

        /// <summary>
        /// Display the Create view. 
        /// When call View(), MVC will ask Razor to parse the content of Create.cshtml
        /// </summary>
        /// <returns>ViewResult of Create</returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// MVC will use model binding,  incoming data is parsed and the key/value
        /// pairs in the HTTP request are used to populate properties of domain model types
        /// </summary>
        /// <param name="note">object that is passed as the parameter to the action method
        ///  is automatically populated with the data from the form fields.</param>
        /// <returns>View of Index so user can see updated notes</returns>
        [HttpPost]
        public ActionResult Create(NoteEntry note)
        {
            if (ModelState.IsValid)
            {
                notebookServices.AddEntry(note);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
    }
}