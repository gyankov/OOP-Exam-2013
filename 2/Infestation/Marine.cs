﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Marine : Human
    {
        public Marine(string id) : base(id)
        {
            this.AddSupplement(new WeaponrySkill());

        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (this.Id==unit.Id)
            {
                return false;
            }

            if (unit.Power<=this.Aggression)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
          var attackableUnit=  attackableUnits.OrderByDescending(x => x.Health).FirstOrDefault();
            return attackableUnit;
        }
    }
}
