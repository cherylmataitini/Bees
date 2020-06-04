using System;
using System.Collections.Generic;

namespace Bees.Models
{
    public abstract class Bee : IBee
    {
        private readonly int _thresholdToDie;

        public float Health { get; private set; }


        protected Bee(int thresholdToDiePercentage)
        {
            Health = 100f;
            _thresholdToDie = thresholdToDiePercentage;
        }

        public bool Dead => Health <= _thresholdToDie;

        public void Damage(int damagePercentage)
        {
            if (damagePercentage >= 0 && damagePercentage <= 100 && !Dead)
            {
                Health -= (Health * damagePercentage / 100f);
            }
        }
    }
}

