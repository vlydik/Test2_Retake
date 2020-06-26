using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Models
{
    public class FireTruck
    {
        [Key]
        public int IdFireTruck { get; set; }
        [Required]
        public string OperationalNumber { get; set; }
        [Required]
        public string SpecialEquipment { get; set; }

        public virtual ICollection<FireTruck_Action> FireTruck_Action { get; set; }
        public object IdFireTruck_Action { get; internal set; }
    }
}
