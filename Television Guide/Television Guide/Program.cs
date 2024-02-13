using System;
using System.Collections.Generic;

class TelevisionProgram
{
    public string Name { get; }
    public int Duration { get; }

    public TelevisionProgram(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"{Name}, {Duration} minutes";
    }

    public bool IsShorterOrEqual(int maxDuration)
    {
        return Duration <= maxDuration;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TelevisionProgram> programs = new List<TelevisionProgram>();

        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break; // Stop reading programs when an empty name is entered
            }

            Console.Write("Duration: ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                programs.Add(new TelevisionProgram(name, duration));
            }
            else
            {
                Console.WriteLine("Invalid input. Duration should be an integer.");
            }
        }

        Console.Write("Program's maximum duration? ");
        if (int.TryParse(Console.ReadLine(), out int maxDuration))
        {
            Console.WriteLine("\nTelevision programs:");
            foreach (var program in programs)
            {
                if (program.IsShorterOrEqual(maxDuration))
                {
                    Console.WriteLine(program);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Maximum duration should be an integer.");
        }
    }
}
