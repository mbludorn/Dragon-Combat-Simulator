using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Combat_Simulator
{
    class Program
    {    
            //Declare all the variables
            public static string userName;
            public static int playerHP = 100;
            public static int dragonHP = 200;
            public static int chance = rng.Next(1,101);
            public static int usersPick;
            public static int dragonPick;
            public static int chance;
            public static int sword = 1;
            public static int magic = 2;
            public static int heal = 3;
            public static int dragon = 4;

            
        static void Main(string[] args)
        {

            //Greet the player and tell them the intsrtuctions of the game by call the Greet Function.
                Greet();

            // Function to play the game!
                DragonGame();

            //Keep the window open.
                Console.ReadKey();
            }

           
        
        static void Greet()
            {
            //Get plays name and tell them the instruction.
            Console.WriteLine("Enter your name!");
            userName  = Console.ReadLine();

            Console.WriteLine("Welcome " +  userName + "!");
            Console.WriteLine("\n Instructions:  ");
            
            }
    
            
            
        
        // Play the game by doing loops in the DragonGame Function until either the player or dragon reach 0 HP's first.   
        static void DragonGame()
            
        {
 
            //Have the Player and Dragon take turns playing.
            Console.WriteLine(userName + ", " + "Enter 1 or 2 to choose your weapon!");
            userName = Console.ReadLine();
            return;

            // if player chooses a 1 (sword).
            if (usersPick == sword) && (playerHP > 0 || dragonHP > 0);
            
            if  (chance > 40)
                {
                    Random rng = new Random(rng.Next(-20, -36));
                    dragonHP = dragonHP + rng.Next(-20, -36);
                    return;
                }

                 Console.WriteLine(userName + ", " + "You wanted to use the sword! The sword is effective 70% of the time.");
                Console.WriteLine("\n You have " + playerHP + " Hit Power left.");
            

            // if dragon chooses a 4.
            if (dragonPick == dragon) &&  (playerHP > 0 || dragonHP > 0);
            
                if (chance > 20)
                {
                    Random rng = new Random(rng.Next(-5, -16));
                    playerHP = playerHP + rng.Next(-5, -16);
                }
                    Console.WriteLine("The dragon will hit you 80% of the time causing 5 - 15 points in damage.");
                    Console.WriteLine("The dragon has " + dragonHP + " Hit Power left.");
                    return;
                
            
            // if player chooses a 2 (magic).
            if  (usersPick == magic) && (playerHP > 0 || dragonHP > 0);
            
              if ( chance == 100)
              {
                Random rng = new Random(rng.Next(-10, -16));
                dragonHP = dragonHP + rng.Next(-10, -16);
                return;
              }
            Console.WriteLine(userName + ", " + "You wanted to use magic! Magic is effective 100% of the time, but causes less damage");
            Console.WriteLine("\n You have " + playerHP + " Hit Power left");

             // if dragon chooses a 4.
            if (dragonPick == dragon) &&  (playerHP > 0 || dragonHP > 0);
            
                if (chance > 20)
                {
                    Random rng = new Random(rng.Next(-5, -16));
                    dragonHP = dragonHP + rng.Next(-5, -16);
                    return;
                }

                    Console.WriteLine("The dragon will hit you 80% of the time causing 5 - 15 points in damage.");
                    Console.WriteLine("The dragon has " + dragonHP + " Hit Power left.");

            
            //if player chooses a 3 (to be healed).
            if (usersPick == heal) && (playerHP > 0 || dragonHP > 0); 
            
               if ( chance == 100)
               {
                Random rng = new Random(rng.Next(10, 21));
                playerHP = playerHP + rng.Next(10, 21);
                return;
               }

                 Console.WriteLine(userName + ", " + " You wanted to heal some of the damage done to you! I hope this helps you!!");
            
            
            // if dragon chooses a 4.
            if (dragonPick == dragon) &&  (playerHP > 0 || dragonHP > 0);
            
                if (chance > 20)
                {
                    Random rng = new Random(rng.Next(-5, -16));
                    dragonHP = dragonHP + rng.Next(-5, -16);
                    return;
                }

                    Console.WriteLine("The dragon will hit you 80% of the time causing 5 - 15 points in damage.");
                    Console.WriteLine("The dragon has " + dragonHP + " Hit Power left.");

            
            // if player is out of HP, game is over
            if (playerHP <= 0)
            {
                Console.WriteLine(userName = ", " + " You have run out of strength to stay alive. The dragon has killed you! ");
                Console.WriteLine("Would you like to try to defeat the dragon again?");
                return;
            }

            //if dragon is ot of HP, game is over
            if (dragonHP <= 0) 
            {
                Console.WriteLine(userName + ", " + " You have defeated the dragon! Congratulations!!");
                Console.WriteLine("Would you like to play again?");
                return;
            }
        }
    }
}
