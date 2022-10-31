using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class NonExistentSpaceship: Exception
    {
        
        private const string EMessage = "Non-existent spaceship.";

        public NonExistentSpaceship () : base(EMessage)
        {

        }
        
    
        
    }
}