using System.ComponentModel.DataAnnotations;

namespace OfficialTM.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }

        public UserModel()
        {
            Id = -1;
            Name = "";
            Email = "";
            Role = "";
        }

        public UserModel(int id, string name, string email, string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Role = role;
        }
    }
}