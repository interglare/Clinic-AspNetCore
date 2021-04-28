using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Profession
    {
        [Key]
        public int profession_id { get; set; }
        public string profession_name { get; set; }
    }
}
