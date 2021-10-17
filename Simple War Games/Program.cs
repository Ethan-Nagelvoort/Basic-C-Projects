using System;
using System.Collections.Generic;
using System.Text;

///<summary>
/// Simple War Game is a collection of classes that implements the basic
/// functionality necessary to construct a simple fighting game.
/// 
/// The Main function of this namespace implements a simple CLI game based
/// around the given 'Tanks' gameplay. Extending the base Entities and Weapons
/// is simple enough to provide the framework for any simple CLI game.
///</summary>
namespace SimpleWarGame
{
    /// <summary>
    /// Main class of the program. Contains the Entry Point.
    /// Also contains the functionality to print the Game Description
    ///  and the weaponType enumeration, which is used to enumerate avalible weapons.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point and main game loop for the game.
        /// Processes a basic game consisting of two tanks. A player and an Enemy target.
        /// Prints appropriate game messages.
        /// </summary>
        /// <param name="args">Command line arguments. [Unused]</param>
        static void Main(string[] args)
        {
            Random random = new Random();
            Player player = new Player();
            Entity target = null;
            ConsoleKeyInfo keypress;

            while (true) // Begin game loop
            {
                // Display the game description
                GameDescMessage();

                // Randomly pick an enemy, either tank or truck
                switch (random.Next(1, 3))
                {
                    case 1:
                        target = new EnemyTank();
                        Console.WriteLine("An enemy tank has appeared in range.");
                        break;
                    case 2:
                        target = new EnemyTruck();
                        Console.WriteLine("An enemy missle-launching truck has appeared in range.");
                        break;
                }

                // Begining of game round code
                Console.WriteLine("They appear to be firing!\n");
                while (player.health > 0 && target.health > 0)// Start round loop
                {
                    while (true)// Start input loop
                    {// The user selects what type of ammo to fire this round
                        Console.WriteLine("What ammo type will you use?");
                        Console.WriteLine("1 = Explosive, 2 = Armor piercing");
                        keypress = Console.ReadKey();
                        Console.WriteLine();
                        if (keypress.Key == ConsoleKey.D1 || keypress.Key == ConsoleKey.NumPad1)
                        {
                            player.SelectWeapon(weaponType.explosive);
                            break;
                        }
                        if (keypress.Key == ConsoleKey.D2 || keypress.Key == ConsoleKey.NumPad2)
                        {
                            player.SelectWeapon(weaponType.piercing);
                            break;
                        }
                        if (keypress.Key == ConsoleKey.Escape)
                            Environment.Exit(1);
                        // If answer is not recognised, tell user and re-prompt
                        Console.WriteLine("I didn't understand your response");
                    }// End input loop
                    Console.Clear();
                    // Here is where we send from one Entity to another the message to process an attack.
                    player.Attack(target);
                    target.Attack(player);

                    // Display the health of Player and Enemy
                    Console.WriteLine("Player health: " + player.health + "  Enemy health: " + target.health);
                    // Round end cleaning
                }// End round loop
                
                // Display game ending messages
                Console.WriteLine("\n");
                if (player.health == 0 && target.health == 0)
                    Console.WriteLine("You and your target destroyed each other!");
                else if (target.health == 0)
                    Console.WriteLine("You destroyed your target!");
                else if (player.health == 0)
                    Console.WriteLine("The enemy has destroyed you!");

                // Prompt user about playing again or exiting
                while (true)// Start input loop
                {
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("1 = Yes, 2 = No");
                    keypress = Console.ReadKey();
                    Console.WriteLine();
                    if (keypress.Key == ConsoleKey.D1 || keypress.Key == ConsoleKey.NumPad1)
                        break;
                    if (keypress.Key == ConsoleKey.D2 ||
                        keypress.Key == ConsoleKey.NumPad2 ||
                        keypress.Key == ConsoleKey.Escape)
                        Environment.Exit(1);
                    // If answer is not recognised, tell user and re-prompt
                    Console.WriteLine("I didn't understand your response");
                }// End input loop

                // User is playing again so heal the Player
                player.Heal();
            }// End game loop
        }// End main()

        /// <summary>
        /// Prints the basic Game Description to the console.
        /// </summary>
        private static void GameDescMessage()//function gives description of game
        {
            Console.Clear();
            Console.WriteLine("Welcome to Simple War Game!");
            Console.WriteLine("You are in a tank defending your territory from an invading ");
            Console.WriteLine("army. The enemy has scattered this area with tanks and ");
            Console.WriteLine("missile trucks. Your job is to seek them out and destroy ");
            Console.WriteLine("them.");
            Console.WriteLine("Each round both you and the enemy will fire. You will have ");
            Console.WriteLine("the choice to fire explosive charges, which do more damage ");
            Console.WriteLine("but are less accurate, or armor piercing rounds, which do ");
            Console.WriteLine("less damage but are much more accurate. Enemy tanks have ");
            Console.WriteLine("about the same armor as yours, while their missile trucks ");
            Console.WriteLine("are more vulnerable but launch very accurate and deadly ");
            Console.WriteLine("missiles.");
            Console.WriteLine("Fortunately, you have a very good mechanic and he is able ");
            Console.WriteLine("to do full repairs in between enemy sightings.");
            Console.WriteLine("You can exit the game at any prompt by hitting escape.");
            Console.WriteLine("");
        }// End GameDescMessage()

    }// Class Program end


    /// <summary>
    /// Enumeration of the weapons that the player can choose from.
    /// </summary>
    public enum weaponType
    {
        /// <summary>
        /// Coresponds to ExplodeAmmo
        /// </summary>
        explosive,
        /// <summary>
        /// Coresponds to PirecingAmmo
        /// </summary>
        piercing,
    }
}
