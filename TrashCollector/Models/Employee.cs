using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {   [Key]
        public int employeeId { get; set; }
        public int employeeZipcode { get; set; }


    }



}