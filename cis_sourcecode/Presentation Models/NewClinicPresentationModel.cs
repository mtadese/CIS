using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Models
{
    public class NewClinicPresentationModel
    {
        public string InternalCode { get; set; }
        public int Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Specialty { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
