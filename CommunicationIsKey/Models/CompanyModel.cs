using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunicationIsKey.Models
{
    public class CompanyModel : BaseEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public string Category { get; set; }

        public CompanyModel()
        {
            Id = -1;
            Name = "";
            Email = "";
            Phone = "";
            Address = "";
            Category = "";
        }

        public CompanyModel(int id, string name, string email, string phone, string address, string category)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            Category = category;
        }
    }
}