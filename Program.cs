﻿using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    public struct enemy
    {
        public string name;
        public int enemyHealth;
    }
    internal class Program
    {
        public static double EnemyHealth = 20, Health = 100, Damage, filament = 49, energy = 100;
        public static double armour = 0.1;
        public static double weapon = 0.5;
        public static double xp = 0;
        public static int pen = 0; //Using this for now, I'm sure we can change it later on^Josh
        public static int roomid;
        public static double difficulty = 0.1;
        public static string EnemyName;

        static void Main(string[] args)
        {
            Start();
        }

        static void will()//method to add a enemy copy this when adding someone to the game
        {
            enemy will;
            will.name = "Will";//sets enemy name
            will.enemyHealth = 25;// sets enemy health
            EnemyHealth = will.enemyHealth;// overides the last enemies health
            EnemyName = will.name;
        }
        static void Equiptment()
        {

            if (weapon == 0.5)
            {
                Console.WriteLine("You have no weapon");
            }

            else if (weapon == 1)
            {
                Console.WriteLine("You have weapon 1");
            }

            else if (weapon == 1.5)
            {
                Console.WriteLine("You have weapon 2");
            }

            else if (weapon == 2)
            {
                Console.WriteLine("You have weapon 3 (Highest Level)");
            }


            if (armour == 0.1)
            {
                Console.WriteLine("You have no Armour");
            }

            else if (armour == 0.5)
            {
                Console.WriteLine("You have Vaughn boots, maybe you should go tramping");
                armour = 0.5;
            }

            else if (armour == 1)
            {
                Console.WriteLine("You have Ginmail");
                armour = 1;
            }

            else if (armour == 1.5)
            {
                Console.WriteLine("You have weapon ResinRanger Rain Coat ");
                armour = 1.5;
            }

            else if (armour == 2)
            {
                Console.WriteLine("You have PLA Power Vest (Highest Level)");
                armour = 2; 
            }
        }
        static void callroom()
        {
            switch (roomid)
            {
                case 0:
                    office();
                    break;
                case 1:
                    Start();
                    break;
                case 2:
                    hallway();
                    break;
                case 3:
                    closet();
                    break;
                case 4:
                    broom1();
                    break;
                case 5:
                    broom2();
                    break;
            }
        }


        static void Start()
        {
            Console.Clear();
            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin!\nSo you can go home and have a great weekend!");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            roomid = 0;
            office();
            fight(); //I belive this should be moved into the office
        }

        //admin/office - item room
        static void office()
        {
            Console.Clear();
            roomid = 1;
            Console.WriteLine("You are in the Office");
            Thread.Sleep(1000);
            Console.WriteLine("Your environmental impact of printing off rain forests of paper for your math exams, has enraged the office lady who appears to be a blob of glue and staplers for hands ");
            Console.WriteLine("You must now fight your way out of this one!");
            will();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "office":
                    Console.WriteLine("Your are already here\n");
                    office();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        static void hallway()
        {
            string temp;
            int input;

            Console.Clear();
            roomid = 2;
            Console.WriteLine("You are in the Hallway");
            Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? ");
            Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground as there are better things to find (0)");
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);

            if (input == 1)
            {
                Console.WriteLine("You have picked up the pen");
                pen = 1;
                Console.ReadLine();
            }

            else
            {
                pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                Console.WriteLine("You choice not to pick up the pen it probaly wasn't important");
            }
            Console.ReadLine();
            Console.WriteLine("");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    hallway();
                    break;
                case "office":
                    office();
                    break;
                case "broom1":
                    broom1();
                    break;
                case "broom2":
                    broom2();
                    break;
                case "closet":
                    closet();
                    break;
            }
        }

        //Janitor Closet 
        static void closet()
        {
            Console.Clear();
            roomid = 3;
            Console.WriteLine("You are in Janitor Closet");

            Console.WriteLine("You enter a dark gloomy room, Krissi appears from the shadows.");
            Console.WriteLine("Vaughn... Have you brought me a pen?? If you would like you see your boots again, I would a pen in return. \n I trust you would have grabbed one from the hallway");

            if (pen == 1)
            {
                Console.WriteLine("Thank you for grabbing my pen, you know I am a true pen thief, thank you");
                Console.WriteLine("Here are your special boots");
                armour = 0.5;
                Console.WriteLine("[YOU EQUPIED YOUR BOOTS]");
            }

            else
            {
                Console.WriteLine("Disappointing you didn't bing me a pen how about you go else where");
            }

            //Add function in here
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "closet":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    closet();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        //Boss Room
        static void broom1()
        {
            
            //Angry Student Boss
            Console.Clear();
            roomid = 4;
            Console.WriteLine("Hi Vaughn, I was just just wondering if you had marked my math exam?");
            //Add option for user to responce
            // If (Yes - don't trigger fight and have other dialogue
            // If (No - Start fight")
            Console.WriteLine("broom1 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom1":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom1();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        //Boss Room
        static void broom2()
        {
            //Business Student Boss
            Console.Clear();
            roomid = 5;
            Console.WriteLine("You enter into a ");
            // I'm not too sure for room, could be a business student who wants to fight you. 
            Console.WriteLine("broom2 hallway"); //??? Not sure what this is - Josh
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom2();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        static void printerRoom(){
            //welcome to the room ect
            Console.WriteLine("1. to make a Wepeon\n2. to make Armor");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("1. Plastic Saber - Low damage (25 Filliment)\n 2. Filament Fencer - medium damage (50 Filliment)\n3. Resin Rapier - highest Damage (100 filliment)");
                choice = Convert.ToInt32(Console.ReadLine());
                if ((choice == 1)||(filament <= 25)) 
                { 

                }
            }
            else if (choice == 2)
            {
                //what 
            }

        }


        static void fight()
        {
            int charge = 0;
            Random random = new Random();
            do
            {
                Console.WriteLine($"You have {Health} HP and {energy} Energy.                                                          {EnemyName} has {EnemyHealth} HP");//Change to name from list
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Choose your move!: 1: Strong Attack 2: Medium Attack 3: Low Attack 4: Charge Attack 5: Gain Energy");
                int option = Convert.ToInt32(Console.ReadLine());
                int hit = random.Next(101);

                switch (option)
                {
                    case 1: if (energy >= 40) { energy -= 40; Damage = random.Next(30, 41); if (hit > 84) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Strong Attack"); break;
                    case 2: if (energy >= 20) { energy -= 20; Damage = random.Next(19, 32); if (hit > 50) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Medium Attack"); break;
                    case 3: if (energy >= 10) { energy -= 10; Damage = random.Next(9, 22); ; if (hit > 25) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Low Attack"); break;
                    case 4: if (charge == 3) { Damage = random.Next(50, 80); EnemyHealth -= Damage; } else charge++; break;
                    case 5: int energyGained = random.Next(1, 50); energy = Math.Min(100, energy + energyGained); break;
                }

                if (EnemyHealth > 0) enemyAttack(); // Enemy attacks only if it's still alive
                Console.WriteLine("\n\n");
            } while (Health > 0 && EnemyHealth > 0);

            if (Health <= 0)
            {
                Console.WriteLine("You have been defeated. Game Over.");
                Console.ReadLine();
                if (difficulty > 1)
                {
                    hallway();
                }
                else 
                {
                    Start();
                }
                
            }
            else if (EnemyHealth <= 0)
            {
                Console.WriteLine("You have defeated the enemy!");
                // Implement logic to reward the player or move to the next part of the game
              
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
                difficulty++;
                 hallway(); 
                
                
            }
        }

        static void enemyAttack()
        {
            Random random = new Random();
            int hit = random.Next(101);
            int enemyChoice = random.Next(1, 5);

            switch (enemyChoice)
            {
                case 1: Damage = 30; if (hit > 75) Health -= Damage; else Console.WriteLine("Enemy missed"); break;//replace enemy name with one from a list
                case 2: Damage = 20; if (hit > 50) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 3: Damage = 10; if (hit > 25) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 4: Damage = 5; if (hit > 1) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
            }
        }
    }
    }
