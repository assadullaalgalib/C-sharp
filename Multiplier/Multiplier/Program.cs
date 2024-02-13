public class Multiplier
{
    private int factor; // Instance variable to store the multiplier

    public Multiplier(int number)
    {
        factor = number; // Initialize the instance variable in the constructor
    }

    public int Multiply(int number)
    {
        int result = factor * number;
        factor = result; // Update the instance variable with the new result
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Multiplier multiplyByThree = new Multiplier(3);
        Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));
        Multiplier multiplyByFour = new Multiplier(4);
        Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
        Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
        Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
        Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
    }
}
