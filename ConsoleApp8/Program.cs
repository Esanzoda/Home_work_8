using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Ali";
            person1.Age = 25;
            person1.City = "Khujand";
            person1.Introduce();

            Person person2 = new Person();
            person1.Name = "Vali";
            person1.Age = 23;
            person1.City = "Dushanbe";
            person1.Introduce();

            Person person3 = new Person();
            person1.Name = "Gani";
            person1.Age = 2;
            person1.City = "Dushanbe";
            person1.Introduce();

            Console.ReadKey();
        }
    }
}
