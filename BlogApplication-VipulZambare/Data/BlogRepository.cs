using BlogApplication_VipulZambare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication_VipulZambare.Data
{
    public class BlogRepository
    {
        BlogDBContext db;

        public BlogRepository()
        {
            db = new BlogDBContext();
        }
        
        public List<Blog> GetAll()
        {
            return db.Blogs.ToList();
        }

        public void AddOrUpdate(Blog blog)
        {
                db.Blogs.Add(blog);
                db.SaveChanges();
        }

        public Blog ChangeBlogStatus(string id, BlogStatus status)
        {
            var blogId = Convert.ToInt32(id);
            var blog = db.Blogs.Where(x => x.BlogId == blogId).First();
            blog.Status = status.ToString();
            db.SaveChanges();
            return blog;
        }

        public Blog GetById(int blogId)
        {
            return db.Blogs.Where(x => x.BlogId == blogId).First();
        }
    }
}