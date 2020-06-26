using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Models
{
    public class FireTruck_Action
    {
        [Key]
        public int IdFireTruck_Action { get; set; }

        public int IdFireTruck { get; set; }
        [ForeignKey("IdFireTruck")]
        public FireTruck FireTruck { get; set; }
        public int IdAction { get; set; }
        [ForeignKey("IdAction")]
        public Action Action { get; set; }

        [Required]
        public DateTime AssignmentDate { get; set; }
    }
}
