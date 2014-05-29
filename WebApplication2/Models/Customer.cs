using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Customer
    {
        public Customer()
        {
                
        }

        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public int Age { get; set; }
    }
}