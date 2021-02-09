using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework.Entities
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }
        public int FirstInput { get; set; }
        public int SecondInput { get; set; }
        public string Operator { get; set; }
        public decimal Result { get; set; }
        public string Error { get; set; }
    }
}
