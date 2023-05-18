using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [StringLength(15)]
        [Required]
        public string CURP { get; set; }

        [StringLength(13)]
        [Required]
        public string RFC { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
