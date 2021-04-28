using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Doctor
    {
        [Key]
        public int doctor_id { get; set; }
        public string doctor_name { get; set; }
    }
}
