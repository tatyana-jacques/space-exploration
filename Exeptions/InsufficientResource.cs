using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace space_exploration
{
    public class InsufficientResource: Exception
    {
        public InsufficientResource(string resourceName): base ($"Not enough {resourceName}"){
            
        }
    }
}