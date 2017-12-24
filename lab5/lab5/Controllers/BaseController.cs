using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft;
using lab5.Models.DBModel;
using Newtonsoft.Json;
using lab5.Models.Repository;

namespace lab5.Controllers
{
    public class BaseController : Controller
    {
        private FeedbackRepository _rep;
        public BaseController()
        {
            _rep = new FeedbackRepository(new PhotoModel());
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertFeedback(Feedback feedback)
        {
           var result = _rep.InsertFeedback(feedback);
            if (result > 0)
            {
                return View("Index");
            }
            else { return View("Index"); }
        }
    }
}
