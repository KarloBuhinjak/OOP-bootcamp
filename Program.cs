using System;
using System.Collections.Generic;

namespace OOP_bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> players = new List<FootballPlayer>();
            MenuManager menuManager = new MenuManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                
                Console.WriteLine("1. Add a new player");
                Console.WriteLine("2. Print all players");
                Console.WriteLine("3. Search for a player");
                Console.WriteLine("4. Show player stats");
                Console.WriteLine("5. Edit player");
                Console.WriteLine("6. Delete a player");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        menuManager.AddNewPlayer(players);
                        break;
                    case "2":
                        menuManager.PrintAllPlayers(players);
                        break;
                    case "3":
                        menuManager.SearchPlayer(players);
                        break;
                    case "4":
                        menuManager.ShowPlayerStats(players);
                        break;
                    case "5":
                        menuManager.EditPlayer(players);
                        break;
                    case "6":
                        menuManager.DeletePlayer(players);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Press Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}
