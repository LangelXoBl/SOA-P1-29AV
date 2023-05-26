using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    [Table("AssetEmployees")]
    public class AssetEmployee
    {
        [Key]
        public int Id { get; set;}
        
        public int EmployeeId { get; set;}
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int AssetId { get; set;}
        [ForeignKey("AssetId")]
        public virtual Asset Asset { get; set; }
        public DateTime AsignationDate { get; set;}
        public DateTime LiberationDate { get; set;}

        public DateTime DeliveryDate { get; set;}
    }
}
