using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Models
{
    public class Firefighter_Action
    {
        public int IdFireFighter { get; set; }
        [ForeignKey("IdFireFighter")]
        public FireFighter FireFighter { get; set; }
        public int IdAction { get; set; }
        [ForeignKey("IdAction")]
        public Action Action { get; set; }
    }
}
