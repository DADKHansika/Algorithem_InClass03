using System.Numerics;
using YourIndexNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*\n");
        Console.WriteLine("\t\tPlese enter prefferd operation");
        Console.WriteLine("\nTo find Factorial enter\t\t\t\t: f");
        Console.WriteLine("To find Fibonacci enter\t\t\t\t: b");
        Console.WriteLine("To find GCD enter\t\t\t\t: g");
        Console.WriteLine("To use Binary Search enter\t\t\t: s");
        Console.WriteLine("To Traverse Directory and Sub-Directories\t: t");
        Console.WriteLine("To exit enter\t\t\t\t\t: e\n");

        Console.Write("Enter the Operation : ");
        string operation = Console.ReadLine();
        Console.WriteLine("\n*\n");

        try
        {
            switch (operation)
            {
                case "f":
                    HandleFactorial();
                    break;
                case "b":
                    HandleFibonacci();
                    break;
                case "g":
                    HandleGCD();
                    break;
                case "s":
                    HandleBinarySearch();
                    break;
                case "e":
                    Console.WriteLine("You have exited the program");
                    break;
                case "t":
                    HandleDirectoryTraverser();
                    break;
                default:
                    Console.WriteLine("You have entered a invalid input");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid input please try again !");
        }
        finally
        {
            Console.WriteLine("\n\t\t\t  Thank You !  \n");
            Console.WriteLine("*\n");
        }
    }

    static string GetUserPrederredMethod()
    {

        Console.WriteLine("Select a method what you want to use to find the factorial");

        Console.WriteLine("For the Recurtion enter\t: r");
        Console.WriteLine("For the Iteration enter\t: i");
        Console.WriteLine("To exit enter \t\t: e\n");

        Console.Write("Enter the Method : ");
        string method = Console.ReadLine();
        Console.WriteLine("");

        if (method == "e")
        {
            Console.WriteLine("You have exited the program");
            Environment.Exit(0);
        }

        Console.WriteLine("*\n");

        return method;


    }

    static void HandleFactorial()
    {

        // Read user prefered method
        string method = GetUserPrederredMethod();

        if (method.Equals("r"))
        {
            // Read the input from userx    

            Console.Write("Enter the number that you want to find the Factorial : ");
            string inputFromUser = Console.ReadLine();

            // call the FactorialFinder.RecurtionFactorial method
            FactorialFinder factorialFinder = new FactorialFinder();
            long result = factorialFinder.RecurtionFactorial(int.Parse(inputFromUser));
            System.Console.WriteLine("Factorial {0} is {1}\n", inputFromUser, result);
        }
        else if (method.Equals("i"))
        {
            Console.Write("Enter the number that you want to find the Factorial : ");
            // Read the input from user
            string inputFromUser = Console.ReadLine();

            // call the FactorialFinder.IterationFactorial method
            FactorialFinder factorialFinder = new FactorialFinder();
            long result = factorialFinder.IterationFactorial(int.Parse(inputFromUser));
            System.Console.WriteLine("Factorial {0} is {1}\n", inputFromUser, result);
        }

    }

    static void HandleFibonacci()
    {

        // Read user prefered method
        string method = GetUserPrederredMethod();

        if (method.Equals("r"))
        {
            // Read the input from user             
            Console.Write("Enter the number that you want to find the Fibonacci : ");
            string inputFromUser = Console.ReadLine();

            // call the FactorialFinder.RecurtionFactorial method
            FibonacciFinder fibonacciFinder = new FibonacciFinder();
            BigInteger result = fibonacciFinder.RecurtionFibonacci(int.Parse(inputFromUser));
            System.Console.WriteLine("Fibonacci {0} is {1}\n", inputFromUser, result);
        }
        else if (method.Equals("i"))
        {
            Console.Write("Enter the number that you want to find the Fibonacci : ");
            // Read the input from user
            string inputFromUser = Console.ReadLine();

            // call the FactorialFinder.IterationFactorial method
            FibonacciFinder fibonacciFinder = new FibonacciFinder();
            BigInteger result = fibonacciFinder.IterationFibonacci(int.Parse(inputFromUser));
            System.Console.WriteLine("Fibonacci {0} is {1}\n", inputFromUser, result);
        }
    }

    static void HandleGCD()
    {
        // Read user prefered method
        string method = GetUserPrederredMethod();

        if (method.Equals("r"))
        {
            // Read the input from user             
            Console.Write("Enter the number 1 : ");
            string number1 = Console.ReadLine();
            Console.Write("Enter the number 2 : ");
            string number2 = Console.ReadLine();

            // call the FactorialFinder.RecurtionFactorial method
            GCDFinder gcdFinder = new GCDFinder();
            int result = gcdFinder.RecurtionGCD(int.Parse(number1), int.Parse(number2));
            Console.WriteLine("GCD of {0} and {1} is {2}\n", number1, number2, result);
        }
        else if (method.Equals("i"))
        {
            Console.Write("Enter the number 1 : ");
            string number1 = Console.ReadLine();
            Console.Write("Enter the number 2 : ");
            string number2 = Console.ReadLine();

            // call the FactorialFinder.IterationFactorial method
            GCDFinder gcdFinder = new GCDFinder();
            int result = gcdFinder.IterationGCD(int.Parse(number1), int.Parse(number2));
            Console.WriteLine("GCD of {0} and {1} is {2}\n", number1, number2, result);
        }
    }

    static void HandleBinarySearch()
    {

        // Read user prefered method
        string method = GetUserPrederredMethod();

        // Read the input from user as a string in order to split it to an array
        Console.Write("Enter the numbers separated by space : ");
        string inputFromUser = Console.ReadLine();

        Console.Write("\nEnter the number that you want to find in the array : ");
        int target = int.Parse(Console.ReadLine());

        // Split the input string to an array of integers
        int[] inputs = inputFromUser.Split(' ').Select(int.Parse).ToArray();

        BinarySearch binarySearch = new BinarySearch();
        if (method.Equals("r"))
        {
            //Get the sorted array
            inputs = binarySearch.SortInputs(inputs);

            int result = binarySearch.RecursiveBinarySearch(inputs, target, 0, inputs.Length - 1);
            Console.WriteLine("The index of {0} in the array is {1}\n", target, result);
        }
        else if (method.Equals("i"))
        {

            // Get the sorted array
            inputs = binarySearch.SortInputs(inputs);

            int result = binarySearch.IterativeBinarySearch(inputs, target);
            Console.WriteLine("The index of {0} in the array is {1}\n", target, result);
        }
    }

    static void HandleDirectoryTraverser()
    {

        // get user prefered method
        string method = GetUserPrederredMethod();

        Console.Write("Enter the directory path : ");
        string Path = Console.ReadLine();
        Console.WriteLine("");

        DirectoryInfo FolderPath = new DirectoryInfo(Path);

        if (method == "r")
        {
            DirectoryTraverser directoryTraverser = new DirectoryTraverser(FolderPath.Name);
            directoryTraverser.RecursiveDirectoryTraverser(FolderPath, 1);
        }
        else if (method == "i")
        {
            DirectoryTraverser directoryTraverser = new DirectoryTraverser(FolderPath.Name);
            directoryTraverser.IterativeDirectoryTraverser(FolderPath);
        }

    }
}