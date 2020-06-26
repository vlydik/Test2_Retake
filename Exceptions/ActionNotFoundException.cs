using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2_Retake.Exceptions
{
    public class ActionNotFoundException: Exception
    {
        public ActionNotFoundException():base("Action does not exist")
        {

        }
    }
}
