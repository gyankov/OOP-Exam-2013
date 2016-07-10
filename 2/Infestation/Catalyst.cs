using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
   public   abstract class  Catalyst : Supplement
    {
        public  Catalyst(int aggressionEffect, int healthEffect, int powerEffect) 
            :base(aggressionEffect,healthEffect,powerEffect)
        {           
        }
    }
}
