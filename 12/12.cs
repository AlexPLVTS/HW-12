namespace _12

{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the index to find its Fibonacci number: ");
            int index = int.Parse(Console.ReadLine());
            int result = FibonacciSequence.Fibonacci(index);
            Console.WriteLine($"Fibonacci number for index {index} : {result}");
        }
    }
}
public static class FibonacciSequence
{
    public static int Fibonacci(int number)
    {
        if (number < 1)
        {
            throw new ArgumentException("Index cannot be less than 1");
        }
        if (number == 1)
        {
            return 0;
        }
        if (number > 46)
        {
            throw new ArgumentException("Fibonacci number exceeds int.MaxValue");
        }
        if (number == 2)
        {
            return 1;
        }
        return Fibonacci(number - 1) + Fibonacci(number - 2);
    }
}