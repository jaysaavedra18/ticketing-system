﻿using OfficialTM.Data;
using OfficialTM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficialTM.Controllers
{
    public class TicketsController : Controller
    {
        private ApplicationDbContext context;

        public TicketsController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Tickets
        public ActionResult Index()
        {
            // fetch data from sql db
            List<TicketModel> tickets = context.Tickets.ToList();

            return View(tickets);
        }

        public ActionResult Create()
        {
            return View("TicketForm", new TicketModel());
        }

        public ActionResult ProcessCreate(TicketModel ticketModel)
        {
            // save to db
            TicketModel ticket = context.Tickets.FirstOrDefault(t => t.Id == ticketModel.Id);

            // edit
            if (ticket != null)
            {
                ticket.Title = ticketModel.Title;
                ticket.Description = ticketModel.Description;
                ticket.Priority = ticketModel.Priority;
                ticket.Submitter = ticketModel.Submitter;
                ticket.Status = ticketModel.Status;

            }
            else
            {
                context.Tickets.Add(ticketModel);
            }

            context.SaveChanges();

            return View("Details", ticketModel);
        }

        public ActionResult Edit(int Id)
        {
            TicketModel ticket = context.Tickets.FirstOrDefault(t => t.Id == Id);

            return View("TicketForm", ticket);
        }

        public ActionResult Details(int Id)
        {
            TicketModel ticket = context.Tickets.FirstOrDefault(t => t.Id == Id);

            return View(ticket);
        }

        public ActionResult Delete(int Id)
        {
            TicketModel ticket = context.Tickets.FirstOrDefault(t => t.Id == Id);

            context.Entry(ticket).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Tickets");
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult SearchForTitle(string searchPhrase)
        {

            // get a list of search results from the database
            var tickets = from t in context.Tickets where t.Title.Contains(searchPhrase)
                          select t;

            return View("Index", tickets);
        }

        public ActionResult SearchForStatus(string searchPhrase)
        {

            // get a list of search results from the database
            var tickets = from t in context.Tickets where t.Status.Contains(searchPhrase)
                          select t;

            return View("Index", tickets);
        }

        public ActionResult SearchForSubmitter(string searchPhrase)
        {

            // get a list of search results from the database
            var tickets = from t in context.Tickets where t.Submitter.Contains(searchPhrase)
                          select t;


            return View("Index", tickets);
        }
    }
}