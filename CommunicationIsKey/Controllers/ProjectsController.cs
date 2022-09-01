using CommunicationIsKey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunicationIsKey.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private ApplicationDbContext context;

        public ProjectsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Projects
        [Authorize]
        public ActionResult Index()
        {

            List<ProjectModel> projects = context.Projects.ToList();

            return View(projects);
        }

        public ActionResult Create()
        {
            return View("ProjectForm", new ProjectModel());
        }

        public ActionResult ProcessCreate(ProjectModel projectModel)
        {
            // save to db
            ProjectModel project = context.Projects.FirstOrDefault(p => p.Id == projectModel.Id);

            // edit
            if (project != null)
            {
                project.Name = projectModel.Name;
                project.Description = projectModel.Description;

            }
            else
            {
                context.Projects.Add(projectModel);
            }

            context.SaveChanges();

            return View("Details", projectModel);
        }

        public ActionResult Edit(int Id)
        {
            ProjectModel project = context.Projects.FirstOrDefault(p => p.Id == Id);

            return View("ProjectForm", project);
        }

        public ActionResult Details(int Id)
        {
            ProjectModel project = context.Projects.SingleOrDefault(p => p.Id == Id);

            return View(project);
        }

        public ActionResult Delete(int Id)
        {
            ProjectModel project = context.Projects.SingleOrDefault(p => p.Id == Id);

            context.Entry(project).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Projects");
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult SearchForName(string searchPhrase)
        {

            // get a list of search results from the database
            var projects = from p in context.Projects where p.Name.Contains(searchPhrase)
                          select p;



            return View("Index", projects);
        }

        public ActionResult SearchForDescription(string searchPhrase)
        {

            // get a list of search results from the database
            var projects = from p in context.Projects where p.Description.Contains(searchPhrase)
                           select p;


            return View("Index", projects);
        }
    }
}