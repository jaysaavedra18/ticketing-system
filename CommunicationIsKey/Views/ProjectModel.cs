using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficialTM.Models
{
    public class ProjectModel: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name="Project Lead")]
        public string ProjectLead { get; set; }


        public ProjectModel()
        {
            Id = -1;
            Name = "";
            Description = "";
            ProjectLead = "";
            
        }

        public ProjectModel(int id, string name, string description, string projectLead)
        {
            Id = id;
            Name = name;
            Description = description;
            ProjectLead = projectLead;
        }

    }


}