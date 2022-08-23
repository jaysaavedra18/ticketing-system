using OfficialTM.Data;
using OfficialTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficialTM.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            // fetch data from sql db
            List<UserModel> users = new List<UserModel>();

            UserDAO userDAO = new UserDAO();

            users = userDAO.FetchAll();


            return View(users);
        }

        public ActionResult Create()
        {
            return View("UserForm", new UserModel());
        }

        public ActionResult ProcessCreate(UserModel userModel)
        {
            // save to db
            UserDAO userDAO = new UserDAO();
            userDAO.CreateOrUpdate(userModel);


            return View("Details", userModel);
        }

        public ActionResult Edit(int Id)
        {
            UserDAO userDAO = new UserDAO();
            UserModel user = userDAO.FetchOne(Id);
            return View("UserForm", user);
        }

        public ActionResult Details(int Id)
        {

            UserDAO usersDAO = new UserDAO();
            UserModel user = usersDAO.FetchOne(Id);

            return View(user);
        }

        public ActionResult Delete(int Id)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.Delete(Id);

            List<UserModel> users = userDAO.FetchAll();

            return View("Index", users);
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult SearchForName(string searchPhrase)
        {

            // get a list of search results from the database

            UserDAO userDAO = new UserDAO();
            List<UserModel> searchResults = userDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }
    }
}