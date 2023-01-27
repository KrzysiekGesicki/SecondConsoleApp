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


            //array example

            string[] names = new string[3] { "Morpheus", "Thomas", "Oracle" };

            string[] nicknames = new string[] { "Homelander", "A-Train", "Starlight" };

            string[] surnames = {"House", "Wilson", "Cuddy"};

            foreach (var n1 in names)
            {
                Console.WriteLine(n1);
            }
            foreach (string n2 in nicknames)
            {
                Console.WriteLine(n2);
            }
            foreach (var n3 in surnames)
            {
                Console.WriteLine(n3);
            }
            Console.ReadLine();





            //array example - multidimensional

            int[,] x = new int[3, 4]; 

            int[,] y = { {3,5}, {6,8}, {7,9}, {8,9} };

            for (int i=0; i<4; i++) // rows
            {
                for (int j=0; j<2; j++) // columns
                {
                    Console.Write(y[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            int[] z = { 2, 44, 1, 9 };

            Console.WriteLine("rank= " + z.Rank);
            Console.WriteLine("length= " + z.Length);

            Console.WriteLine("max= " + z.Max());
            Console.WriteLine("min= " + z.Min());
            Console.WriteLine("sum= " + z.Sum());
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
