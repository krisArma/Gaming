using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    class Berserk : Monster 
    {
        //setting for the Berserk monster, got from the Monster class
        public void BerserkSet()
        {
            hp = 800;      //health point of Berserk monster
            attack = 50;   //attack point for Berserk monster
            name = "Berserk"; //Naming class
            mp = 100;
        }

        public void BerserkComing()
        {
            //this void showing up when player choose the character
            Console.WriteLine("Watch out for Berserk Rampage !!");
        }

        /*public override void PlayerAttack ()
        {
            //this void showing up when Berserk attack
            Console.WriteLine("Berserk SLAM !!");
        }*/

        public int Attack()
        {
            //This method return total damage which berserk will give
            int damage;
            Random chance = new Random();
            int attackChance = chance.Next(1, 5);
            
            //Berserk has 80% of succesing land its attack
            //So we build this if
            if(attackChance != 1)
            {
                attack = chance.Next(40, 55);   //Berserker damage between 40 until 55
                return attack;
            } else
            {
                damage = 0;
                return damage;
            }  
        }
        public int SpeacialAttack()
        {
            //Because Berserk Class didn't have any special Attack, the value which will be returned is -1
            return -1;
        }

        public int Heal ()
        {
            //this will return how much health point will be restored when Berserk using Heal
            return 40;
        }
    }
}
