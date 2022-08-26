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
    public class ContractsController : Controller
    {
        private ApplicationDbContext context;

        public ContractsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Contracts
        public ActionResult Index()
        {
            // fetch data from sql db
            List<ContractModel> contracts = context.Contracts.ToList();

            return View(contracts);
        }

        public ActionResult Create()
        {
            return View("ContractForm", new ContractModel());
        }

        public ActionResult ProcessCreate(ContractModel contractModel)
        {
            // save to db
            ContractModel contract = context.Contracts.FirstOrDefault(c => c.Id == contractModel.Id);

            // edit
            if (contract != null)
            {
                contract.Company = contractModel.Company;
                contract.Address = contractModel.Address;
                contract.Plan = contractModel.Plan;
                contract.Price = contractModel.Price;
            }
            else
            {
                context.Contracts.Add(contractModel);
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

            return View("Details", contractModel);
        }

        public ActionResult Edit(int Id)
        {
            ContractModel contract = context.Contracts.FirstOrDefault(c => c.Id == Id);

            return View("ContractForm", contract);
        }

        public ActionResult Details(int Id)
        {
            ContractModel contract = context.Contracts.FirstOrDefault(c => c.Id == Id);

            return View(contract);
        }

        public ActionResult Delete(int Id)
        {
            ContractModel contract = context.Contracts.FirstOrDefault(c => c.Id == Id);

            context.Entry(contract).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Contracts");
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult SearchForCompany(string searchPhrase)
        {

            // get a list of search results from the database
            var contracts = from t in context.Contracts
                            where t.Company.Contains(searchPhrase)
                            select t;

            return View("Index", contracts);
        }

        public ActionResult SearchForAddress(string searchPhrase)
        {

            // get a list of search results from the database
            var contracts = from t in context.Contracts
                            where t.Address.Contains(searchPhrase)
                            select t;

            return View("Index", contracts);
        }

        public ActionResult SearchForPlan(string searchPhrase)
        {

            // get a list of search results from the database
            var contracts = from t in context.Contracts
                            where t.Plan.Contains(searchPhrase)
                            select t;

            return View("Index", contracts);
        }
    }
}