using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    [Table("Assets")]
    public class Asset
    {
        [Key]
        public int Id {  get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
