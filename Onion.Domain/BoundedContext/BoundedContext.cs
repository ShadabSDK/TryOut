using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Domain.BoundedContext
{
    //Aggregare Root
    public class BoundedContext
    {
        public string State { get;}

        public BoundedContext(string state)
        {
            State = state;
        }

        public void Behaviour(string behaviour)
        {
            //Logic 
        }
    }
}
