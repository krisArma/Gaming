using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gaming
{
    class Choose
    {
        //getter setter of player1 and player2 so it can be accsessed in outter class 
        public int player1 { get; internal set; }
        public int player2 { get; internal set; }

        public void Choosing ()
            //this function retrieve data of choosen character
        {
            int choosen;    //variable that save the selected character
            //int player1 = 0;    //this will save the selected character of Player 1
            //int player2 = 0;    //this will save the selected character of Player 2
            int[] players = new int[2];  //this will hold all player in the turn for choosing character
            
            //instance of each class Berserk, Warrior, and Mage
            Berserk berserk = new Berserk();
            Mage mage = new Mage();
            Warrior warrior = new Warrior();

          
            //Constructor of each class
            mage.MageSet();
            berserk.BerserkSet();
            warrior.WarriorSet();


            for (int i = 0; i < 2; i++)
            {
                start:
                Console.WriteLine("==============================================================");
                Console.WriteLine("                   Choose the Character                       "); // Showing the title menu
                Console.WriteLine("==============================================================");
                Console.WriteLine("  Class \t Attack \t HP \t MP \t Special Ability"); // head of title
                Console.WriteLine("1.{0} \t {1} \t\t {2} \t {3} \t none", berserk.name, berserk.attack, berserk.hp, berserk.mp); //showing the name, status, and attack of each class
                Console.WriteLine("2.{0} \t\t {1} \t\t {2} \t {3} \t Dark Energy", mage.name, mage.attack, mage.hp, mage.mp);
                Console.WriteLine("3.{0} \t {1} \t\t {2} \t {3} \t Dragon Dance\n\n", warrior.name, warrior.attack, warrior.hp, warrior.mp);
                Console.Write("Who is yout choice ?");
                choosen = int.Parse(Console.ReadLine());    //Read the user choice

                switch (choosen)
                {
                    //This switch showing up the character coming in text
                    case 1:
                        berserk.BerserkComing();
                        break;
                    case 2:
                        mage.MageComing();
                        break;
                    case 3:
                        warrior.WarriorComing();
                        break;
                    case 13:
                        Console.WriteLine("ROACH");
                        break;
                    default:
                        Console.WriteLine("Invalid Character Input again ! \n");    //when the input invalid, user will be throwing back to the menu
                        goto start;
                        break;
                }
                if (i < 1)
                {
                    Console.WriteLine("Press Enter to choose Player2's character");
                    Console.ReadLine();
                    Console.Clear();
                    player1 = choosen;
                }
                else
                {
                    player2 = choosen;
                }
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
