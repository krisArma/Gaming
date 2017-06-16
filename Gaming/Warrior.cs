using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    class Warrior : Monster
    {
        public void WarriorSet ()
        {
            //This setting of a Warrior Class
            hp = 660;
            attack = 45;
            name = "Warrior";
            mp = 130;
        }

        public void WarriorComing()
        {
            //This void showing up when Warrior is choosen
            Console.WriteLine("Be Brave Warrior !");

        }

        public override void PlayerAttack()
        {
            //This void showing up when Warrior attack
            Console.WriteLine("Warrior Salsh !");
        }

        public int Attack()
        {
            //This method return total damage which warrior will give
            int damage;
            Random chance = new Random();
            int attackChance = chance.Next(1, 5);

            //Warrior has 80% of succesing land its attack
            //So we build this if
            if (attackChance != 1)
            {
                return attack = 45;
            }
            else
            {
                //This will be indicated as miss in the game
                damage = 0;
                return damage;
            }

        }

        public int DragonDance ()
        {
            //This method told us about Warrior's special Attack called Dragon Dance
            Random chance = new Random();
            int attackChance = chance.Next(1, 2);   //Dragon Dance has 50% hit chance
            if (attackChance == 1)
            {
                return chance.Next(75, 80);         //with 75 - 80 damage
                base.mp = base.mp - 55;
            }
            else
            {
                return 0;
            }
        }

        public int Heal()
        {
            //This is health point will be received by warrior when use Heal
            return 40;
        }
    }
}
