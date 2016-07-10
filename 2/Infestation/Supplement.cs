using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
  public   abstract class  Supplement : ISupplement
    {
   

        public  Supplement(int aggressionEffect, int healthEffect, int powerEffect)
        {
           this.AggressionEffect = aggressionEffect;
           this.HealthEffect = healthEffect;
           this.PowerEffect = powerEffect;
        }

        public virtual int AggressionEffect
        {
            get; protected set;
            
        }

        public virtual int HealthEffect
        {
            get; protected set;
         
        }

        public virtual int PowerEffect
        {
            get; protected set;
           
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            
        }
    }
}
