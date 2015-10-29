using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public int HospitalNumber { get; set; }
        public Title Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public string HomeAddress { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
    }
}
