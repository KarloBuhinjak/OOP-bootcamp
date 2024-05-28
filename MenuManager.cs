namespace OOP_bootcamp;

public class MenuManager
{
    public void AddNewPlayer(List<FootballPlayer> players)
    {
        Console.WriteLine("Enter the player's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the player's age:");
        int age = GetValidIntegerInput();

        Console.WriteLine("Enter the player's position:");
        string position = Console.ReadLine();
        
        Console.WriteLine("Enter the player's club:");
        string clubName = Console.ReadLine();
        Console.WriteLine("Enter the club's country:");
        string clubCountry = Console.ReadLine();
        Club club = new Club(clubName, clubCountry);
        
        Console.WriteLine($"Enter the number of total goals scored by {name}:");
        int totalGoals = GetValidIntegerInput();
        Console.WriteLine($"Enter the number of total assists assisted by {name}:");
        int totalAssists = GetValidIntegerInput();
        Console.WriteLine($"Enter the number of {name}'s total yellow cards:");
        int totalYellowCards = GetValidIntegerInput();
        Console.WriteLine($"Enter the number of {name}'s total red cards:");
        int totalRedCards = GetValidIntegerInput();
        Console.WriteLine($"Enter the number of {name}'s total matches:");
        int totalMatches = GetValidIntegerInput();
        

        FootballPlayer player = new FootballPlayer(name, age, position, club, totalGoals, totalAssists, totalYellowCards, totalRedCards, totalMatches);
        players.Add(player);

        Console.WriteLine("New player added.");
    }

    public void PrintAllPlayers(List<FootballPlayer> players)
    {
        if (players.Count == 0)
        {
            Console.WriteLine("There are no players to print.");
            return;
        }

        Console.WriteLine("List of players:");
        foreach (FootballPlayer player in players)
        {
            player.DisplayInfo();
        }
    }
    public void EditPlayer(List<FootballPlayer> players)
    {
        Console.WriteLine("Enter the name of the player to edit:");
        string editName = Console.ReadLine();

        FootballPlayer player = FindPlayerByName(players, editName);
        if (player != null)
        {
            Console.WriteLine("Current player info:");
            player.DisplayInfo();

            Console.WriteLine("Enter new age (or press Enter to keep current):");
            
            int? newAge = GetValidIntegerInput();
            if (newAge.HasValue)
                player.Age = newAge.Value;
            Console.WriteLine("Enter new position (or press Enter to keep current):");
            string newPosition = Console.ReadLine();
            if (!string.IsNullOrEmpty(newPosition))
                player.Position = newPosition;

            Console.WriteLine("Enter new club name (or press Enter to keep current):");
            string newClubName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newClubName))
            {
                Console.WriteLine("Enter new club country:");
                string newClubCountry = Console.ReadLine();
                player.Club = new Club(newClubName, newClubCountry);
            }

            Console.WriteLine("Enter new number of goals scored (or press Enter to keep current):");
            int? newGoalsScored = GetValidIntegerInput();
            if (newGoalsScored.HasValue)
                player.GoalsScored = newGoalsScored.Value;

            Console.WriteLine("Enter new number of assists (or press Enter to keep current):");
            int? newAssists = GetValidIntegerInput();
            if (newAssists.HasValue)
                player.Assists = newAssists.Value;

            Console.WriteLine("Enter new number of yellow cards (or press Enter to keep current):");
            int? newYellowCards = GetValidIntegerInput();
            if (newYellowCards.HasValue)
                player.YellowCards = newYellowCards.Value;

            Console.WriteLine("Enter new number of red cards (or press Enter to keep current):");
            int? newRedCards = GetValidIntegerInput();
            if (newRedCards.HasValue)
                player.RedCards = newRedCards.Value;

            Console.WriteLine("Enter new number of total matches (or press Enter to keep current):");
            int? newTotalMatches = GetValidIntegerInput();
            if (newTotalMatches.HasValue)
                player.TotalMatches = newTotalMatches.Value;

            Console.WriteLine("Player info updated.");
        }
        else
        {
            Console.WriteLine("Player not found.");
        }
    }
    
    public void DeletePlayer(List<FootballPlayer> players)
    {
        Console.WriteLine("Enter the name of the player to delete:");
        string deleteName = Console.ReadLine();

        FootballPlayer player = FindPlayerByName(players, deleteName);
        if (player != null)
        {
            players.Remove(player);
            Console.WriteLine("Player successfully deleted.");
        }
        else
        {
            Console.WriteLine("Player not found.");
        }
    }
    
    public void SearchPlayer(List<FootballPlayer> players)
    {
        Console.WriteLine("Enter the name of the player to search:");
        string searchName = Console.ReadLine();

        FootballPlayer player = FindPlayerByName(players, searchName);
        if (player != null)
        {
            player.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Player not found.");
        }
    }
    
    public void ShowPlayerStats(List<FootballPlayer> players)
    {
        Console.WriteLine("Enter the name of the player:");
        string playerName = Console.ReadLine();

        FootballPlayer player = FindPlayerByName(players, playerName);
        if (player != null)
        {
            Console.WriteLine($"Stats for player {playerName}:");
            Console.WriteLine($"Goals scored: {player.GoalsScored}");
            Console.WriteLine($"Assists: {player.Assists}");
            Console.WriteLine($"Yellow cards: {player.YellowCards}");
            Console.WriteLine($"Red cards: {player.RedCards}");
            Console.WriteLine($"Total matches: {player.TotalMatches}");
            Console.WriteLine($"Average goals per match: {player.AverageGoalsPerMatch():F2}");
            Console.WriteLine($"Average assists per match: {player.AverageAssistsPerMatch():F2}");
            Console.WriteLine($"Average yellow cards per match: {player.AverageYellowCardsPerMatch():F2}");
            Console.WriteLine($"Average red cards per match: {player.AverageRedCardsPerMatch():F2}");

        }
        else
        {
            Console.WriteLine("Player not found.");
        }
    }
    
    private FootballPlayer FindPlayerByName(List<FootballPlayer> players, string playerName)
    {
        return players.Find(player => player.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
    }
    private int GetValidIntegerInput()
    {
        int result;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        return result;
    }
}