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

        public FootballPlayer(string name, int age, string position, Club club)
            : base(name, age)
        {
            Position = position;
            Club = club;
            GoalsScored = 0;
            Assists = 0;
            YellowCards = 0;
            RedCards = 0;
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Club: {Club.Name}");
        }
        
        public int CalculateTotalGoalsAndAssists(int goalsScored, int assists)
        {
            return goalsScored + assists;
        }
    }

}