using System;

public class Gauge
{
    public int value { get; set; }

    public Gauge()
    {
        value = 0;
    }

    public void Increase()
    {
        if (value < 5)
        {
            value++;
        }
    }

    public void Decrease()
    {
        if (value > 0)
        {
            value--;
        }
    }

    public bool Full()
    {
        return (value == 5);
    }
}

public static void Main(string[] args)
{
    Gauge g = new Gauge();
    while (!g.Full())
    {
        Console.WriteLine("Not full! Value: " + g.value);
        g.Increase();
    }

    Console.WriteLine("Full! Value: " + g.value);
    g.Decrease();
    Console.WriteLine("Not full! Value: " + g.value);
}
