using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.Make = "Toyota";
            MyCar.Model = "Takoma";
            MyCar.Year = 2007;
            Console.WriteLine($"{MyCar.Make},{MyCar.Model},{MyCar.Year}");

            var Dodge = new Car()
            {
                Make = "Dodge Challenger",
                Model = "Hellcat",
                Year = 2015,
            };
            Console.WriteLine($"{Dodge.Make}, {Dodge.Model}, {Dodge.Year}");
            
        }

       
    }
}
