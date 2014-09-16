using CSC440_Project.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSC440_Project.Controllers
{
    //[Authorize(Users = "awhoward112@gmail.com")]
    [UserAuthorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            //send them to the upload view?
            return View();
        }
    }
}