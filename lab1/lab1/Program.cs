using System;

namespace LabTask
{
    class Lab1
    {
        public void prog1()
        {
            string Name = "";
            Console.Write("Please Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("User Name: " + name);
        }

        public void prog2()
        {
            int Age = 0;
            Console.Write("Please Enter your age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("User Age: " + Age);
        }

        public void prog3()
        {
            int Age = 0;
            // Console.Write("Please Enter your age: ");
            try
            {
                Age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("User Name: " + Age);
            }
            catch (Exception)
            {
                Console.WriteLine("You must Enter Numeric value as your age.");
            }
        }
    }

    class Lab2
    {
        public void prog1o()
        {
            string Name = "";
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();

            if (Name.Length > 10)
                Console.WriteLine("Name must be within 10 characters.");
            else
                Console.WriteLine("User Name: " + Name);
        }

        public void prog2o()
        {
            string Name = "";
            Console.Write("Please enter your name: ");
            // You can put a single line comment
            /* or, if you wish, 
               you can put a multiple line comment
               like this
            */
        }

        public void prog3o()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Lab1 lab1 = new Lab1();
            Lab2 lab2 = new Lab2();

            // Lab1
            lab1.prog1();
            lab1.prog2();
            lab1.prog3();

            // Lab2
            lab2.prog1o();
            lab2.prog2o();
            lab2.prog3o();
        }
    }
}

