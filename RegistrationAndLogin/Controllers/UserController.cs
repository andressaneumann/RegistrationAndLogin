using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationAndLogin.Models;

namespace RegistrationAndLogin.Controllers
{
    public class UserController : Controller
    {

        //Registration Action

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }


        //Registration POST action

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude ="IsEmailVerified")] User user)
        {

            //


            return View(user);
        }

        //Verify Email

        //Verify Email LINK

        //Login

        //Login POST

        //Logout

    }
}