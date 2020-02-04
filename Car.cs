using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Car
    {
        private static string[] Makes = { "BMW", "Mersedec", "Audi", "Vollkswagen", "Toyota", "Hyundai", "Mazda", "Kia", "Lexus",
           "Lada", "Chevrolet","Renault","Nissan","Honda"};
        private static Random rd = new Random();
        public string Make { get; set; }
        public string Year { get; set; }
        public int HP { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }

        public Car()
        {
            Make = Makes[rd.Next(0, Makes.Length - 1)];
            Year = Convert.ToString(rd.Next(2000, 2019));
            HP = rd.Next(85, 330);
            Price = rd.Next(1500, 65000);
        }
        public Car(string make, string year, int hp, decimal price, string model = "unknown model")
        {
            this.Make = make;
            this.Year = year;
            this.HP = hp;
            this.Price = price;
            this.Model = model;
        }
        static Car()
        {

        }

        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}y\t{HP}hp\t{Price}$";
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
            {
                Car car = obj as Car;
                return this.HP == car.HP && this.Price == car.Price && this.Year == car.Year;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator <(Car car1, Car car2)
        {
            return car1.Price < car2.Price;
        }
        public static bool operator >(Car car1, Car car2)
        {
            return car1.Price > car2.Price;
        }
        public static bool operator ==(Car car1, Car car2)
        {
            return car1.Price == car2.Price;
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }


    }
}
