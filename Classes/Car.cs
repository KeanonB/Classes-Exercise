using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car() 
        {
            string Make;
            string Model;
            int Year;
            
        }

        public Car(string make, string model, int year) 
        {
            var Make = make;
            var Model = model;
            var Year = year;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
