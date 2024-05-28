using FootballApp;

namespace OOP_bootcamp
{
    public class FootballPlayer : Person, IStats
    {
        public string Position { get; set; }
        public Club Club { get; set; }
        public int GoalsScored { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int TotalMatches { get; set; }

        public FootballPlayer(string name, int age, string position, Club club, int goalsScored, int assists, int yellowCards,int redCards, int totalMatches)
            : base(name, age)
        {
            Position = position;
            Club = club;
            GoalsScored = goalsScored;
            Assists = assists;
            YellowCards = yellowCards;
            RedCards = redCards;
            TotalMatches = totalMatches;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"| Name: {Name, 2} |");
            Console.WriteLine($"| Age: {Age,2} |");
            Console.WriteLine($"| Club: {Club.Name, 2} |");
            Console.WriteLine($"| Position: {Position, 2} |");
            Console.WriteLine($"| Goals: {GoalsScored,2} | Assists: {Assists,2} |");
            Console.WriteLine($"| Yellow Cards: {YellowCards,2} | Red Cards: {RedCards,2} |");
            Console.WriteLine($"| Total Matches: {TotalMatches,2} |");
            Console.WriteLine($"----------------------------------------");
        }

        
        public int CalculateTotalGoalsAndAssists()
        {
            return GoalsScored + Assists;
        }
        public double AverageGoalsPerMatch()
        {
            if (TotalMatches == 0)
                return 0;
    
            return (double)GoalsScored / TotalMatches;
        }

        public double AverageAssistsPerMatch()
        {
            if (TotalMatches == 0)
                return 0;
    
            return (double)Assists / TotalMatches;
        }

        public double AverageYellowCardsPerMatch()
        {
            if (TotalMatches == 0)
                return 0;
    
            return (double)YellowCards / TotalMatches;
        }

        public double AverageRedCardsPerMatch()
        {
            if (TotalMatches == 0)
                return 0;
    
            return (double)RedCards / TotalMatches;
        }
    }

}