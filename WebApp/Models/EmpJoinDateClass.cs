using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class EmpJoinDateClass
    {
        [Key]
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public DateTime Joindate { get; set; }
    }
}
