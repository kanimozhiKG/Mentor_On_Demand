using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApiUsingEF.Models
{[Table("Employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [StringLength(20)]
        public string EName { get; set; }
        public DateTime? JoinDate { get; set; }
        [StringLength(30)]
        public string Desig { get; set; }
        public double? Sal { get; set; }
        [ForeignKey("Department")]
        public string Did { get; set; }
        public Department Department { get; set; }
    }
}
