//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwesomeBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int blogID { get; set; }
        public string body { get; set; }
        public string title { get; set; }
        public int favorite { get; set; }
        public System.DateTime postDate { get; set; }
        public string author { get; set; }
        public string tags { get; set; }
        public string thumbnail { get; set; }
        public int viewCount { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
