using System.ComponentModel.DataAnnotations;

namespace CIS.Application.Entities
{
    public class User
    {
        [Key]
        public int Identifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ModuleAccess { get; set; }
    }
}
