using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    class Battlefield
    {
        //This class will handle the battle phase 
        public void Battle ()
        {
            string[] charVoice = new string[2];   //Voice of character when it attacks

            Choose choose = new Choose();   //Firstly call the Choose class, which handled the choosing characters progress
            choose.Choosing();
            Console.Clear();

            Berserk berserk = new Berserk();    //instance for the monster in Battlefield Class
            berserk.BerserkSet();
            Mage mage = new Mage();
            mage.MageSet();
            Warrior warrior = new Warrior();
            warrior.WarriorSet();

            String[] character = new String[] { "Berserk", "Mage", "Warrior" };     //Save the characther into an array

            Console.WriteLine("READY !!");
            Console.WriteLine("{0} VS {1}", character[(choose.player1) - 1], character[(choose.player2) - 1]);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
            Console.Clear();

            //int[] player1 = new int[3];     //this array will held the amount of HP and MP player 1
            //int[] player2 = new int[3];     //this array will held the amount of HP and MP player 2

            int[][] player = new int[2][];  //this jagged array will held the characteristic of each character
            player[0] = new int[5];         //array for player 1
            player[1] = new int[5];         //array for player 2
             
            switch (choose.player1)
                //This switched the player1 decision, so the monster attribut can be adjusted
            {
                case 1:
                    player[0][0] = berserk.hp;
                    player[0][1] = berserk.Attack();
                    player[0][2] = berserk.Heal();
                    player[0][3] = berserk.mp;
                    player[0][4] = berserk.SpeacialAttack();
                    charVoice[0] = "Berserk SLAM !!";
                    break;
                case 2:
                    player[0][0] = mage.hp;
                    player[0][1] = mage.Attack();
                    player[0][2] = mage.Heal();
                    player[0][3] = mage.mp;
                    player[0][4] = mage.DarkEnergy();
                    charVoice[0] = "Burning Flame !!";
                    break;
                case 3:
                    player[0][0] = warrior.hp;
                    player[0][1] = warrior.Attack();
                    player[0][2] = warrior.Heal();
                    player[0][3] = warrior.mp;
                    player[0][4] = warrior.DragonDance();
                    charVoice[0] = "Warrior's Slash !!";
                    break;
            }
            switch (choose.player2)
            //This switched the player2 decision, so the monster attribut can be adjusted
            {
                case 1:
                    player[1][0] = berserk.hp;
                    player[1][1] = berserk.Attack();
                    player[1][2] = berserk.Heal();
                    player[1][3] = berserk.mp;
                    player[1][4] = berserk.SpeacialAttack();
                    charVoice[1] = "Berserk SLAM !! ";
                    break;
                case 2:
                    player[1][0] = mage.hp;
                    player[1][1] = mage.Attack();
                    player[1][2] = mage.Heal();
                    player[1][3] = mage.mp;
                    player[1][4] = mage.DarkEnergy();
                    charVoice[1] = "Burning Flame !! ";
                    break;
                case 3:
                    player[1][0] = warrior.hp;
                    player[1][1] = warrior.Attack();
                    player[1][2] = warrior.Heal();
                    player[1][3] = warrior.mp;
                    player[1][4] = warrior.DragonDance();
                    charVoice[1] = "Warrior's Slash !! ";
                    break;
            }

            Console.WriteLine("==================================");
            Console.WriteLine("            FIGHT !!              ");
            Console.WriteLine("==================================\n\n");

            //This is the real fight !
            while (player[0][0] > 0 && player[1][0] > 0)
            {
                int action; //The user choice

                for (int i = 0; i < 2; i++ )
                {
                    switch (choose.player1)
                    {
                        //because the damage will different in each Attacking phase of each player
                        //This switch was build to handle that
                        case 1:
                            player[0][1] = berserk.Attack();
                            break;
                        case 2:
                            player[0][1] = mage.Attack();
                            break;
                        case 3:
                            player[0][1] = warrior.Attack();
                            break;
                    }
                    switch (choose.player2)
                    {
                        case 1:
                            player[1][1] = berserk.Attack();
                            break;
                        case 2:
                            player[1][1] = mage.Attack();
                            break;
                        case 3:
                            player[1][1] = warrior.Attack();
                            break;
                    }

                    //This phase where the game begin
                    start:
                    Console.WriteLine("==================================");
                    Console.WriteLine("Player{0} turn ", i + 1);
                    Console.WriteLine("HP : {0} \t\t MP : {1}", player[i][0], player[i][3]);
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Heal");
                    Console.WriteLine("3. Special Attack");
                    Console.Write("=> ");
                    action = int.Parse(Console.ReadLine());
                    
                    if (action == 1)
                    {
                        //When the player choose to attack
                        if (player[i][1] != 0)
                        {
                            Console.WriteLine("{0} make {1} damages on player {2} !! \n", charVoice[i], player[0 + i][1], 2 - i);
                            player[(1 - i)][0] = player[(1 - i)][0] - player[i][1];
                            Console.WriteLine("player 1 HP => {0}", player[0][0]);
                            Console.WriteLine("player 2 HP => {0}", player[1][0]);
                            Console.WriteLine("==================================\n");
                        } else
                        {
                            Console.WriteLine("Miss ! 0 Damage");
                            Console.WriteLine("player 1 HP => {0}", player[0][0]);
                            Console.WriteLine("player 2 HP => {0}", player[1][0]);
                            Console.WriteLine("==================================\n");
                        }
                    }
                    else if (action == 2)
                    {
                        //When Player choose Heal
                        if(player[i][3] >= 50)
                        {
                            player[i][0] += player[i][2];
                            player[i][3] -= 50;
                            Console.WriteLine("Recover {0} HP", player[i][2]);
                            Console.WriteLine("player 1 HP => {0}", player[0][0]);
                            Console.WriteLine("player 2 HP => {0}", player[1][0]);
                            Console.WriteLine("==================================\n");
                        } else
                        {
                            Console.WriteLine("Insufficient Mana !!");
                            Console.WriteLine("player 1 HP => {0}", player[0][0]);
                            Console.WriteLine("player 2 HP => {0}", player[1][0]);
                            Console.WriteLine("==================================\n");
                            goto start;
                        }
                    }
                    if (player[0][0] <= 0 || player[1][0] <= 0)
                    {
                        break;
                    }
                }
                /*int action;

                Console.WriteLine("Player1 turn ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Do Nothing");
                Console.Write("=> ");
                action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Player 1 attack !! make {0} damages on player 2 !!", player1[1]);
                    player2[0] = player2[0] - player1[1];
                    Console.WriteLine("player 1 HP => {0}", player1[0]);
                    Console.WriteLine("player 2 HP => {0}", player2[0]);
                    Console.WriteLine("==================================");
                } else
                {
                    Console.WriteLine("Do Nothing . . . ");
                    Console.WriteLine("player 1 HP => {0}", player1[0]);
                    Console.WriteLine("player 2 HP => {0}", player2[0]);
                    Console.WriteLine("==================================");
                }

                Console.WriteLine("Player2 turn ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Do Nothing");
                Console.Write("=> ");
                action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Console.WriteLine("Player 2 attack !! make {0} damages on player 1 !!", player2[1]);
                    player1[0] = player1[0] - player2[1];
                    Console.WriteLine("player 1 HP => {0}", player1[0]);
                    Console.WriteLine("player 2 HP => {0}", player2[0]);
                    Console.WriteLine("==================================\n\n");
                }
                else
                {
                    Console.WriteLine("Do Nothing . . . ");
                    Console.WriteLine("player 1 HP => {0}", player1[0]);
                    Console.WriteLine("player 2 HP => {0}", player2[0]);
                    Console.WriteLine("==================================\n\n");
                } */
            }

            //The Winner declaration
            if(player[0][0] > player[1][0])
            {
                Console.WriteLine("Player 1 ({0}) Win.. !", character[choose.player1 - 1]);
            } else
            {
                Console.WriteLine("Player 2 ({0}) Win.. !", character[choose.player2 - 1]);
            }
        }
    }
}
