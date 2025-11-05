using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage2
{
    class Program
    {
        static Random random = new Random();
        private static int rollDice(int numberOfRolls)
        {
            int total = 0;
            for(int i = 0; i < numberOfRolls; i++)
            {
                total += random.Next(1, 7);
            }
            return total;
        }

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(rollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(rollDice(1));

            while(true)
            {
                Console.WriteLine("0 for no magic/flaming\n1 for magic\n2 for flaming\n" +
                    "3 for both\n anything else to quit: ");

                char key = Console.ReadKey().KeyChar;
                if(key != '0' && key != '1' && key != 2 && key != 3)
                {
                    return;
                }
                Console.WriteLine("\nS for sword, A for arrow\n anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);
            }
        }

    }
}
