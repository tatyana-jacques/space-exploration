using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class InsufficientLife : Exception
    {
        private const string EMessage = "Impossible attack. The attacked spaceship life is null.";
        public InsufficientLife() : base(EMessage)
        {

        }
    }
}