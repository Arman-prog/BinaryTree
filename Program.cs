using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<Car> cars = new BinaryTree<Car>();
            cars.PrintLeft();
            cars.Add(new Car { HP=150,Make="Toyota",Model="Corolla",Price=8000,Year="2009"});
            cars.Add(new Car { HP = 180, Make = "Lexus", Model = "RX", Price = 12000, Year = "2008" });
            cars.Add(new Car { HP = 220, Make = "BMW", Model = "328", Price = 9000, Year = "2008" });
            cars.Add(new Car { HP = 85, Make = "Nissan", Model = "Yaris", Price = 5000, Year = "2009" });
            cars.Add(new Car { HP = 170, Make = "Honda", Model = "Accord", Price = 7800, Year = "2009" });
            cars.Add(new Car { HP = 125, Make = "Opel", Model = "Astra G", Price = 3000, Year = "2001" });
            cars.Add(new Car { HP = 234, Make = "BMW", Model = "e92", Price = 9500, Year = "2008" });
            cars.Add(new Car { HP = 143, Make = "Hyundai", Model = "Elantra", Price = 8200, Year = "2012" });
            cars.Add(new Car());

            Console.WriteLine(cars.ElCount);

            cars.Print();

            Console.WriteLine(new string('-',20));
            Console.WriteLine("---LEFT---");
            cars.PrintLeft();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("---RIGHT---");
            cars.PrintRight();
                       
        }
    }
}
