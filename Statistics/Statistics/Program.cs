using System;

namespace exercise_105
{
    public class Statistics
    {
        public int count { get; set; }
        public int sum { get; set; }

        public Statistics()
        {
            // Initialize the variables in the constructor
            count = 0;
            sum = 0;
        }

        public void AddNumber(int number)
        {
            // Update count and sum when a number is added
            count++;
            sum += number;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);
        }
    }
}
