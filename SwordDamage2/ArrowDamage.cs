using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage2
{
    class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.25M;
        private const decimal FLAME_DAMAGE = 1.25M;
        public int Damage
        {
            get; private set;
        }

        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                calculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                calculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                calculateDamage();
            }
        }

        private void calculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if(Magic)
            {
                baseDamage *= MAGIC_MULTIPLIER;
            }
            if(flaming)
            {
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            }
            else
            {
                Damage = (int)Math.Ceiling(baseDamage);
            }
        }

        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            calculateDamage();
        }
    }
}