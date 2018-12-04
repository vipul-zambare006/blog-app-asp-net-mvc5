using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApplication_VipulZambare.Models
{
    public class BlogUser
    {
        [Key]
        public int BlogUserId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Role { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}