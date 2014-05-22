using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AwesomeBlog.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            try
            {
                //to create a new user we use:
                var newUser = Membership.CreateUser("jordan", "jordan", "test@test.com");

                //to log in user:
                FormsAuthentication.SetAuthCookie("jordan", false);

                //to validate user:
                if (Membership.ValidateUser("jordan", "password"))
                {
                    //log them in
                }
                else
                {
                    //username/password dont match
                }
            }
            catch (Exception e)
            {

                return Content(e.Message);
            }


            return Content("OK");
          
        }


        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Login login)
        {
            if (Membership.ValidateUser(login.Username, login.Password))
            {
                //valid user
                FormsAuthentication.SetAuthCookie(login.Username, false);
                return RedirectToAction("index", "home");
            }
            else
            {
                //invalid user
                ViewBag.ErrorMessage = "So invalid credentials, much try again.";
                return View(login);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Register register)
        {
            try
            {
                var user = Membership.CreateUser(register.Username, register.Password, register.Email);
                FormsAuthentication.SetAuthCookie(register.Username, false);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(register);
            }
        }

        
    }
}



