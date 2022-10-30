using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class InsufficientLife : Exception
    {

        public InsufficientLife(): base("Impossible attack. The attacked spaceship life is null.")
        {

        }
    }
}