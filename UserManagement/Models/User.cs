using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string mobileNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime lastModified { get; set; }

    }
}