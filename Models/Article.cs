using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Article
    {
       [Key]
        public int ID { get; set; }
        public String Name { get; set; }
    }
}