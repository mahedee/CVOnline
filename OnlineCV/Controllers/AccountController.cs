using OnlineCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineCV.Controllers
{
    public class AccountController : Controller
    {
        //
        [HttpGet]
        public ActionResult Login()
        {
            @ViewBag.Title = "Login: Online CV Builder";
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login loginData)
        {
            if (ModelState.IsValid)
            {
                OnlineCvContext db = new OnlineCvContext();
                User u = db.Users.FirstOrDefault(x => x.Email == loginData.UserName);
                if (u != null && u.Password == loginData.Password)
                {
                    Session.Remove("name");
                    Session["name"] = u.Name;
                    ViewData["name"] = u.Name;
                    System.Web.Security.FormsAuthentication.SetAuthCookie(u.Email, false);
                    //return Json(Url.Action("About", "Home", null));
                    return Json(new { ok = true, newurl = Url.Action("About","Home",null) });
                    //return Json(new { url = Url.Action("About","Home",null) });
                    //return RedirectToAction("About", "Home", null);
                    //return RedirectToAction("Index", "Member", new { area = "MemberZone" });
                }
                else
                {
                    return Json(new { ok = false, message = "Invalid Credentials" });
                    //return View(loginData);ok = false, message = ex.Message
                }
            }
            else
            {
                return Json(new { ok = false, message = "  Enter your Credentials" });
                //return View(loginData);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
            // return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            @ViewBag.Title = "Registration: Online CV Builder";
            return PartialView();
        }
        [HttpPost]
        public ActionResult Register(Registration userData)
        {
            if (ModelState.IsValid)
            {
                OnlineCvContext db = new OnlineCvContext();

                User user = new User();
                user.Email = userData.Email;
                user.Name = userData.Name;
                user.Password = userData.Password;
                db.Users.Add(user);

                db.SaveChanges();
                Session.Remove("name");
                Session["name"] = user.Name;
                System.Web.Security.FormsAuthentication.SetAuthCookie(userData.Email, false);
                return Json(Url.Action("About", "Home",null));
            }
            else
            {
                return View(userData);
            }
            //return View();
        }

    }
}
