﻿using CSC440_Project.Attributes;
using CSC440_Project.Models;
using FileHelpers.DataLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSC440_Project.Controllers
{
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
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(string filepath)
        {
            //we want to check here that the first file in the request is not null
            if (Request.Files[0] != null)
            {
                var file = Request.Files[0];


                byte[] data = new byte[file.ContentLength];

                ParseInputFile(data);
            }

            ViewBag.Message = "Success!";

            return View("Index");
        }

        private void ParseInputFile(byte[] data)
        {

        }
    }
}