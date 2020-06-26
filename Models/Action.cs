using System;
using System.Collections;
using System.Collections.Generic;

namespace Test2_Retake.Models
{
    public class Action
    {
        [Key]
        public int IdAction { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public string NeedSpecialEquipment { get; set; }

        public virtual ICollection<FireFighter_Action> FireFighter_Action { get; set; }

        public virtual ICollection<FireTruck_Action> FireTruck_Action { get; set; }

    }

}
