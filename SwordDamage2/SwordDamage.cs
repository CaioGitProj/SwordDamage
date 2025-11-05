using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage2
{
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
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
            decimal magicMultiplier = 1M;
            if (Magic)
            {
                magicMultiplier = 1.75M;
            }

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if(flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }

        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            calculateDamage();
        }
    }
}