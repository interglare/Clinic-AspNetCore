using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Patient
    {
        public int  Id { get; set; }
        public string patient_name { get; set; }
        public int doctor_id { get; set; }
        public int? profession_id { get; set; }

    }
}
