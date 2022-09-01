using CommunicationIsKey.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunicationIsKey.Controllers
{
    [Authorize]
    public class CompaniesController : Controller
    {
        private ApplicationDbContext context;

        public CompaniesController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Companies
        public ActionResult Index()
        {
            // fetch data from sql db
            List<CompanyModel> companies = context.Companies.ToList();

            return View(companies);
        }

        public ActionResult Create()
        {
            return View("CompanyForm", new CompanyModel());
        }

        public ActionResult ProcessCreate(CompanyModel companyModel)
        {
            // save to db
            CompanyModel company = context.Companies.FirstOrDefault(c => c.Id == companyModel.Id);

            // edit
            if (company != null)
            {
                company.Name = companyModel.Name;
                company.Email = companyModel.Email;
                company.Phone = companyModel.Phone;
                company.Address = companyModel.Address;
                company.Category = companyModel.Category;
            }
            else
            {
                context.Companies.Add(companyModel);
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Debug.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }

            return View("Details", companyModel);
        }

        public ActionResult Edit(int Id)
        {
            CompanyModel company = context.Companies.FirstOrDefault(c => c.Id == Id);

            return View("CompanyForm", company);
        }

        public ActionResult Details(int Id)
        {
            CompanyModel company = context.Companies.FirstOrDefault(c => c.Id == Id);

            return View(company);
        }

        public ActionResult Delete(int Id)
        {
            CompanyModel company = context.Companies.FirstOrDefault(c => c.Id == Id);

            context.Entry(company).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Companies");
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult SearchForName(string searchPhrase)
        {

            // get a list of search results from the database
            var companies = from t in context.Companies
                            where t.Name.Contains(searchPhrase)
                            select t;

            return View("Index", companies);
        }

        public ActionResult SearchForAddress(string searchPhrase)
        {

            // get a list of search results from the database
            var companies = from t in context.Companies
                            where t.Address.Contains(searchPhrase)
                            select t;

            return View("Index", companies);
        }

        public ActionResult SearchForCategory(string searchPhrase)
        {

            // get a list of search results from the database
            var companies = from t in context.Companies
                            where t.Category.Contains(searchPhrase)
                            select t;

            return View("Index", companies);
        }
    }
}