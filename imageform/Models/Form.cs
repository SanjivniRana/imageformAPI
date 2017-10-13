using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace imageform.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Image { get; set; }
    }
}