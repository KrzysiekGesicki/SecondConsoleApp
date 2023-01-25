using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Jason = new Person();
            Jason.Name = "Jason";
            Jason.Age = 15;
            Console.WriteLine($"Persons name is: {Jason.Name}");
            Console.WriteLine($"Persons age is: {Jason.Age}");

            Console.ReadLine();
        }
    }

    class Person
    {
        private string name;
        private int age;

        //constructor example:
        public Person()
        {
            age = 0;
        }



        //property example:
        
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set { 
                if (value > 0)
                age = value; 
            }
        }




    }
}
