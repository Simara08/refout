using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine
{
    class CapacityLimitExcepsion:Exception
    {
        public CapacityLimitExcepsion(string message):base(message)
        {
            throw new CapacityLimitExcepsion(" Capacity out of Limit");
        }
    }
   
    
}
