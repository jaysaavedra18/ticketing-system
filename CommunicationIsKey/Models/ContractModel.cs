using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunicationIsKey.Models
{
    public class ContractModel : BaseEntity
    {
        [Required]
        [Display(Name="Contract ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Company Name")]
        public string Company { get; set; }
        [Required]
        [Display(Name ="Company Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name ="Selected Plan")]
        public string Plan { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        public ContractModel()
        {
            Id = -1;
            Company = "";
            Address = "";
            Plan = "";
            Price = 0;
        }

        public ContractModel(int id, string company, string address, string plan, decimal price)
        {
            Id = id;
            Company = company;
            Address = address;
            Plan = plan;
            Price = price;
        }
    }
}
