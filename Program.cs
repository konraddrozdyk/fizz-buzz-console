// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a command.");
            return;
        }

        switch (args[0].ToLower())
        {
            case "fizzbuzz":
                RunFizzBuzz(args);
                break;
                case "addFizzBuzz":
                RunAddFizzBuzz(args);
                break;
            default:
                Console.WriteLine("Invalid command.");
                break;
        }
    }

    private static void RunAddFizzBuzz(string[] args)
    {
        
    }

    static void RunFizzBuzz(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide a number (N) for FizzBuzz.");
            return;
        }

        if (!int.TryParse(args[1], out int n))
        {
            Console.WriteLine("Invalid number. Please enter a valid integer.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}