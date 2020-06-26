using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Exceptions
{
    public class FireFighterNotFoundException : Exception
    {
        public FireFighterNotFoundException() : base("FireFighter not found")
        {

        }
    }
}
