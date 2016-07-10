using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public  class EffectableSupplement : Supplement
    {
      protected  bool hasEffect = false;

        public EffectableSupplement(int aggressionEffect, int healthEffect, int powerEffect) 
            : base(aggressionEffect, healthEffect, powerEffect)
        {
        }

        public override int AggressionEffect
        {
            get
            {
                if (!hasEffect)
                {
                    return 0;

                }
                else
                {
                    return base.AggressionEffect;
                }
            }

            protected set
            {
                base.AggressionEffect = value;
            }
        }

        public override int HealthEffect
        {
            get
            {
                if (!hasEffect)
                {
                    return 0;
                }
                else
                {
                    return base.HealthEffect;
                }
            }

            protected set
            {
                base.HealthEffect = value;
            }
        }

        public override int PowerEffect
        {
            get
            {
                if (!hasEffect)
                {
                    return 0;
                }
                else
                {
                    return base.PowerEffect;
                }
            }

            protected set
            {
                base.PowerEffect = value;
            }
        }
    }
}
