namespace OOP_bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Club barcelona = new Club("FC Barcelona", "Spain");
            FootballPlayer messi = new FootballPlayer("Lionel Messi", 34, "Forward", barcelona);
            messi.GoalsScored = 50;
            messi.Assists = 30;
            int totalGoalsAndAssistsMessi = messi.CalculateTotalGoalsAndAssists(messi.GoalsScored, messi.Assists);
            Console.WriteLine($"Total goals and assists: {totalGoalsAndAssistsMessi}");
            
            FootballPlayer xavi = new FootballPlayer("Xavi", 37, "Midfielder", barcelona);
            messi.GoalsScored = 5;
            messi.Assists = 16;
            int totalGoalsAndAssistsXavi = messi.CalculateTotalGoalsAndAssists(messi.GoalsScored, messi.Assists);
            Console.WriteLine($"Total goals and assists: {totalGoalsAndAssistsXavi}");
            
            List<FootballPlayer> players = new List<FootballPlayer>();
            players.Add(messi);
            players.Add(xavi);
            
            foreach (FootballPlayer player in players)
            {
                player.DisplayInfo();
                
            }
            
        }
    }
}