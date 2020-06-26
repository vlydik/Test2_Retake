using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Models
{
    public class Firefighter
    {
        [Key]
        public int IdFireFighter { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual ICollection<FireFighter_Action> FireFighter_Action { get; set; }

    }
}
