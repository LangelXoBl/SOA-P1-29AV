using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int EmployeNumber { get; set; }
        [Required]
        public DateTime Created_at { get; set; }
        [Required]
        public bool State { get; set; }
    }
}
