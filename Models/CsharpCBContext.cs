using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class CsharpCBContext : DbContext
    {
        public CsharpCBContext() : base("CsharpConnection")
        {

        }

        public DbSet<Article> Article { get; set; }

    }
}