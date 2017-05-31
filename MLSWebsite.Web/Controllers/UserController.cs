using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MLSWebsite.Core;
using MLSWebsite.Core.Interfaces;
using MLSWebsite.Infrastructure;
using MLSWebsite.Web.Models;

namespace MLSWebsite.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository repository = null;

        public UserController()
        {
            this.repository = new UserRepository();
        }
        public UserController(IUserRepository userRepo)
        {
            this.repository = userRepo;
        }

        // GET: User
        public ActionResult Index()
        {
            UserViewModel UserModel = new UserViewModel();
            UserModel.Users = (List<user>)repository.SelectAll();
            UserModel.userList = new SelectList(UserModel.Users, "userID", "username");
            return View(UserModel);
        }
    }
}