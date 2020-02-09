using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                .Where(i => i.IsActive == true && i.IsHome == true)
                .Select(i => new BlogModel()
                {
                    Id = i.Id,
                    Title = i.Title.Length > 100 ? i.Title.Substring(0, 100) + "..." : i.Title,
                    Description = i.Description,
                    AddDate = i.AddDate,
                    IsActive = i.IsActive,
                    IsHome = i.IsHome,
                    ImageURL = i.ImageURL,
                });
                
          
            return View(blogs.ToList());
        }
    }
}