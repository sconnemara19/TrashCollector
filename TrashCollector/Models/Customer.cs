﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {   [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display (Name = "City")]
        public string City { get; set; }

        [Display (Name = " State")]
        public string State { get; set; }

        [Display (Name = "Zipcode")]
        public string Zipcode { get; set; }

        [Display (Name = "Pickup Day")]
        public string pickupDay { get; set; }
        
        [Display(Name = "Balance")]
        public double balance  { get; set; }

        [Display(Name = "Monthly Charges")]
        public double monthlyCharge { get; set; }

        [Display(Name = "Pickup Confirmed")]
        public bool pickupConfirmed { get; set; }
        
        [Display(Name = "Start Suspension" )]
        public DateTime  Start { get; set; }

        [Display(Name = "End Suspension")]
        public DateTime End  { get; set; }





    }
}