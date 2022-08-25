using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficialTM.Models
{
    public class TicketModel: BaseEntity
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

        
        public string Priority { get; set; }

        
        public string Type { get; set; }
        


        public TicketModel()
        {
            Id = -1;
            Title = "";
            Description = "";
            Submitter = "";
        }

        public TicketModel(int id, string title, string description, string submitter, string status, string priority, string type)
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

    public class BaseEntity
    {
        [Display(Name ="Date Created")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Date Updated")]
        public DateTime UpdatedDate { get; set; }

    }
}
