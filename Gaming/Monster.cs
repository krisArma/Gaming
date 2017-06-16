using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    //Main class for all monster
    class Monster
    {
        private int _hp;  //health point  for all monster
        private int _attack;     //attack for all monster
        private String _name;   //name of the monster
        private int _mp;        //Mana Point of the monster

        //getter setter for all monster so all monster has different value of HP
        public int hp
        {
            set { _hp = value; }
            get { return _hp; }
        }

        //getter setter for attack of all monster
        public int attack
        {
            set { _attack = value; }
            get { return _attack; }
        }

        //getter setter for the name of all monster
        public String name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int mp
        {
            set { _mp = value; }
            get { return _mp; }
        }

        public virtual void PlayerAttack()    //this methods just show the status attack to the screen
        {
            Console.WriteLine("Player Attack !!");  //namePlayer depends on its class
        }


    }
}
