using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApplication_VipulZambare.Models
{
    public class Blog
    {
        [Key]
        [Required]
        public int BlogId { get; set; }
        [Required]

        public BlogUser User { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name="Banner Image")]
        public string BannerImgUrl { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Status { get; set; }
        [Display(Name = "Publish To Date")]
        public DateTime PublishToDate { get; set; }
    }
}