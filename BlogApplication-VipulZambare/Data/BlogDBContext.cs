using BlogApplication_VipulZambare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApplication_VipulZambare.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext() : base("DefaultConnection")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogUser> BlogUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}