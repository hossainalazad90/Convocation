using Convocation.Data.Enumerations;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convocation.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => FirstName + " " + MiddleName + " " + LastName;                

        public GenderEnum Gender { get; set; }

        public MaritalStatusEnum MaritalStatus { get; set; }

        public string NID { get; set; }

        public string BirthRegistrationID { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Occupation { get; set; }

        public string PresentAddress { get; set; }

        public string PermanentAddress { get; set; }
        

    }
}
