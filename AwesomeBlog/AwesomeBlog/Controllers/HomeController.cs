using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwesomeBlog.Controllers
{
    public class HomeController : Controller
    {
        //stetup 1. Set up database access
        Models.myBlogEntities db = new Models.myBlogEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var list = db.Posts.OrderByDescending(x => x.postDate);
            return View(list);
        }

        public ActionResult Like(int id)
        {
            //get post from database
            var post = db.Posts.Where(x => x.blogID == id).First();
            //increment the likes
            post.favorite += 1;
            //save changes to the database
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        
        public ActionResult AddComment (int id, FormCollection values)
        {
            //making a new comment object to add to our database
            var comment = new Models.Comment();
            //set the vaules on our object from the vaules passed in by the form
            comment.postID = id;
            comment.author = values["author"];
            comment.body = values["body"];
            comment.postedOn = DateTime.Now;
            comment.streetCred = 0;

            //add our comment to the database
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
