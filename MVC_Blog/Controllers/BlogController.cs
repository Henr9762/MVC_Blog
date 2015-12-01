﻿using System.Web.Mvc;
using RepoBlog.Factories;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        PostFac postFac = new PostFac();

        // GET: Blog
        public ActionResult Index()
        {
            return View(postFac.GetIndexData());
        }
    }
}