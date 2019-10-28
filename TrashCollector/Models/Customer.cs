using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {   [Key]
        public int Id { get; set; }
        public string firstName  { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public int zipcode { get; set; }
        public string pickupDay { get; set; }
        public double balance  { get; set; }
        public double monthlyCharge { get; set; }
        public Boolean pickupConfirmed { get; set; }
        public string  Start { get; set; }
        public string End  { get; set; }





    }
}