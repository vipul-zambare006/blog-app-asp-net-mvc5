using BlogApplication_VipulZambare.Data;
using BlogApplication_VipulZambare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication_VipulZambare.Controllers
{
    public class BlogController : Controller
    {
        BlogRepository blogRepo;
        public BlogController()
        {
            blogRepo = new BlogRepository();
        }
        // GET: Blog
        public ActionResult Index()
        {
           var blogs =  blogRepo.GetAll();
            return View(blogs);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            BlogRepository blogRepo = new BlogRepository();
            blogRepo.AddOrUpdate(blog);
            return View();
        }

        [HttpGet]
        public ActionResult Draft(string id)
        {
            BlogRepository blogRepo = new BlogRepository();
            var blog = blogRepo.ChangeBlogStatus(id,BlogStatus.Draft);
            return View("View", blog);
        }

        [HttpGet]
        public ActionResult ReadyToPublish(string id)
        {
            BlogRepository blogRepo = new BlogRepository();
            var blog = blogRepo.ChangeBlogStatus(id, BlogStatus.ReadyToPublish);
            return View("View", blog);
        }


        [HttpGet]
        public ActionResult Publish(string id)
        {
            BlogRepository blogRepo = new BlogRepository();
            var blog = blogRepo.ChangeBlogStatus(id, BlogStatus.Published);
            return View("View", blog);
        }

        [HttpGet]
        public ActionResult Reject(string id)
        {
            BlogRepository blogRepo = new BlogRepository();
            var blog = blogRepo.ChangeBlogStatus(id, BlogStatus.Reject);
            return View("View", blog);
        }


        [HttpGet]
        public ActionResult View(int id)
        {
            BlogRepository blogRepo = new BlogRepository();
            var blog = blogRepo.GetById(id);
            return View(blog);
        }
    }
}