namespace MD3
{
    public class Person
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }    
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }
        public bool IsAdult
        {
            get
            {
                return Age >= 18;
            }
        }

        public Car Car { get; set; }
        public void Greeting()
        {
            Console.WriteLine($"Hello my name is: {Name} Surname: {SurName} and I am {Age} old");

        }
        public bool GetIsAdult()
        {

            return Age >= 18;
        }

    }
}
