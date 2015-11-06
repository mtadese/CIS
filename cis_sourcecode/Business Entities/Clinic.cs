using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.Application.Entities
{
    public class Clinic
    {
        [Key]
        public int Identifier { get; set; }
        public string InternalCode { get; set; }
        public Title Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Specialty { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
