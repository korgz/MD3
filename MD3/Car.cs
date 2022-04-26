namespace MD3
{
    public class Car
    {

        public string Brand2 { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Starting drive");
        }
        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine("Speed -" + Speed);
            return Speed;
        }
        public void Beep()
        {
            Console.WriteLine($"{Brand2} Beep");

        }
        public double SlowDown()
        {
            Speed -= 10;
            Console.WriteLine("Speed -" + Speed);
            return Speed;
        }
        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stop");

        }
    }
}
