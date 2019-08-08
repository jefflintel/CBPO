using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBPO.Models
{
    public class AdultDemographics
    {
        [Key]
        public int UserId { get; set; }
        public IdentityUser User { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Income { get; set; }
        public String Employer { get; set; }
    }
}
