// See https://aka.ms/new-console-template for more information

using MD3;

Person person = new Person();

person.Name = "Dators";
person.Age = 500;
person.IsMale = true;

person.Greeting();




Phone phone = new Phone();

phone.Size = 512;
phone.Brand = "ipone";
phone.Model = "five";

phone.Call();
phone.Sms();

Car car = new Car();

car.Brand2 = "ople";
car.NumberPlate = "hs7427";
car.Speed = 56;

car.StartToDrive();
car.GoFaster();
car.Beep();
car.SlowDown();
car.Stop();


Person artis = new Person();
Console.WriteLine("Ievadi savu vārdu");
artis.Name = Console.ReadLine();

Console.WriteLine("Ievadi savu uzvardu");
artis.SurName = Console.ReadLine();

Console.WriteLine("Ievadi savu vecumu");
artis.Age = 00;


artis.IsMale = true;


artis.Greeting();

bool isArtisAdult = artis.IsAdult;
bool isArtisAdult2 = artis.GetIsAdult();
Console.WriteLine(isArtisAdult);
Console.WriteLine(isArtisAdult2);

person.Car = new Car();
person.Car.Brand2 = "volvo";
person.Car.Beep();



//Product product = new Product();

//product.Height = 512;
//product.Width = "ipone";
//product.Weight = "five";

//product.Pro();

//Product product = new Product();

//product.Height = 52;
//product.Weight = "1";
//product.Width = "1";

//product.Product1();


//Console.WriteLine("Hello, World!");
//namespace MD3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Phone phone1 = new Phone();
//            phone1.model = 4;
//            phone1.size = "small";
//            phone1.brand = "ipone";
//            Console.WriteLine(phone1.model);
//            Console.ReadLine();
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Phone phone1 = new Phone();
//        phone1.size = "small";
//        phone1.brand = "ipone";
//        phone1.model = 4;

//        Console.WriteLine(phone1.size);

//        Console.Readline();
//    }
//}