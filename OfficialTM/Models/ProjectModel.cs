using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficialTM.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public ProjectModel()
        {
            Id = -1;
            Name = "";
            Description = "";
            
        }

        public ProjectModel(int id, string name, string description, List<int> assignedUserIds, List<int> assignedTicketIds)
        {
            Id = id;
            Name = name;
            Description = description;

        }

    }
}