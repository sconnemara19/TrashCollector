using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {[Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        
        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }
        [Display(Name = "Pickup Day")]
        public string pickupDay { get; set; }
        [Display(Name = "Balance")]
        public double balance  { get; set; }
        public double monthlyCharge { get; set; }
        public Boolean pickupConfirmed { get; set; }
        public string  Start { get; set; }
        public string End  { get; set; }





    }
}