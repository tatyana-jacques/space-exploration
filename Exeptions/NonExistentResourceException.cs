using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class NonExistentResourceException: Exception
    {
        private const string EMessage = "Non-existent resource.";

        public NonExistentResourceException () : base(EMessage)
        {

        }
        
    }
}