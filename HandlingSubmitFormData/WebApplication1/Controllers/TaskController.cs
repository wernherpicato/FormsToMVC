using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateEdit(int Id = 0)
        {
            //Loads all models, FeedbackContext initializes all the DBSets
            var context = new FeedbackContext();
                       
            //Selects all categories in the database via 'contect' and saves it in viewbag

            ViewBag.Categories = context.Categories.Select(
                x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();


                if (Id != 0)
                {
                    return View(context.Tasks.FirstOrDefault(x => x.Id == Id));
                }


            return View();
        }
    }
}