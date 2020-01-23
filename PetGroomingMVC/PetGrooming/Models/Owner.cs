using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        [Key]
        public int OwnerId { get; set; }
        public string OwnerFname { get; set; }
        public string OwnerLname { get; set; }
        public string OwnerAddr { get; set; }
        public string OwnerPh { get; set; }
        public string OwnerEmail { get; set; }





    }
}