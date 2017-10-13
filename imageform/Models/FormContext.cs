using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace imageform.Models
{
    public class FormContext : DbContext
    {
        public FormContext() : base("MyConnection") { }
        public DbSet<Form> Forms { get; set; }
    }
}