using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AwesomeBlog.Models
{
    [MetadataType(typeof(PostMetadata))]
    public partial class Post
    {

    }

    public class PostMetadata
    {
        [Required(ErrorMessage = "You need to enter a title."), Display(Name = "Title")]
        public string title;

        [Required(ErrorMessage = "Date required.") , Display(Name = "Dated Posted")]
        public DateTime postDate;

        [Required(ErrorMessage = "Author required.") , Display(Name = "Author")] 
        public string author;

        [Display(Name = "Post Image"), MaxLength(200)]
        public string thumbnail;

        [Required(ErrorMessage = "Body required."), Display(Name = "Content")]
        public string body;

        [Display(Name = "Likes")]
        public string favorite;

        [Display(Name = "Views")]
        public int viewCount;

        [Display(Name = "Tags")]
        public string tags;
    }
}