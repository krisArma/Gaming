using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    class Mage : Monster
    {
        public void MageSet ()
        {
            //Basic setting for Mage included health point and the attack point
            hp = 450;
            attack = 40;
            name = "Mage";
            mp = 200;
        }

        public void MageComing ()
        {
            //This void showing up when Player choose Mage
            Console.WriteLine("Split it UP MAGE !!");
        }

        public override void PlayerAttack()
        {
            //This void showing up when Mage is Attacking
            Console.WriteLine("Mage is casting");
        }

        public int Attack()
        {
            //This method return total damage which mage will give
            int damage;
            Random chance = new Random();
            int attackChance = chance.Next(1, 3);   //this random will decide the attack will in or miss

            //Mage has 70% of succesing land its attack
            //So we build this if
            if (attackChance != 1)
            {
                attack = chance.Next(40, 45);   //Mage damage between 40 until 45
                return attack;
            }
            else
            {
                //it will indicate as miss in the game
                damage = 0;
                return damage;
            }

        }

        public int DarkEnergy()
        {
            //This method told about Mage's special Attack called Dark Energy
            Random chance = new Random();
            int attackChance = chance.Next(1, 3);   //Dark Energy has 33% hit chance
            if(attackChance == 1)
            {
                return chance.Next(100, 130);        //With 90 - 100 damage
            }
            else
            {
                return 0;
            }
        }

        public int Heal ()
        {
            //This is health point which Mage will receive when use Heal
            return 50;
        }

    }
}
