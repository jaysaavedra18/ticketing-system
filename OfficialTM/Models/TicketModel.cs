using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficialTM.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Submitter { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public string Type { get; set; }


        public TicketModel()
        {
            Id = -1;
            Title = "";
            Description = "";
            Submitter = "";
            Status = "";
            Priority = -1;
            Type = "";
        }

        public TicketModel(int id, string title, string description, string submitter, string status, int priority, string type)
        {
            Id = id;
            Title = title;
            Description = description;
            Submitter = submitter;
            Status = status;
            Priority = priority;
            Type = type;
        }
    }
}