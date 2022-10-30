using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public interface IOrbitable
    {
        Dictionary <string,string> OrbitData();
        
    }
}