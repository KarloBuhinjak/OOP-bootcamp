namespace FootballApp
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected  Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public abstract void DisplayInfo();


    }
}
