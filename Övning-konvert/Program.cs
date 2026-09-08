namespace Övning_konvert;

class Program {
    
    //TODO: Implementera konverteringar
    
    // static void Main(string[] args) {
    //     Console.Write("Write temperature in Celsius: ");
    //     var celsius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    //     var fahrenheit = celsius * 9 / 5 + 32;
    //     Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
    // }

    //TODO: Implementera TryParse
    
    // public static void Main(string[] args) {
    //     Console.Write("Write a number: ");
    //     bool isParse = int.TryParse(Console.ReadLine(), out int number);
    //
    //     if (!isParse) {
    //         Console.WriteLine("Not a number");
    //     }
    // }

    //TODO: Implementera Random
    
    // public static void Main(string[] args) {
    //     var random = new Random();
    //     Console.WriteLine("We throw an die");
    //
    //     string enter = "";
    //     while (enter is "") {
    //         int result = random.Next(1, 7);
    //         Console.WriteLine($"The result is {result}");
    //         Console.WriteLine("Press enter to throw again");
    //         enter = Console.ReadLine() ?? "";
    //     }
    // }

    public static void Main(string[] args) {
        Console.WriteLine("Welcome to calculator");
        Console.WriteLine("Enter first number: ");
        bool isFirstNumberValid = double.TryParse(Console.ReadLine(), out double firstNumber);
        Console.WriteLine("Enter second number: ");
        bool isSecondNumberValid = double.TryParse(Console.ReadLine(), out double secondNumber);
        
        char operation = GetValidCharInput("Please enter a valid operation (+, -, *, /): ");

        if (!isFirstNumberValid || !isSecondNumberValid) {
            
        }
    }
    
    private static double GetValidNumberInput(string question) {
        Console.WriteLine(question);
        double result;
        
        while (!double.TryParse(Console.ReadLine(), out result)) {
            Console.WriteLine("Please enter a valid number.");
            Console.WriteLine(Enumerable.Repeat('-', Console.BufferWidth).ToArray());
        }

        return result;
    }
    
    private static char GetValidCharInput(string question) {
        Console.WriteLine(question);
        char result;

        while (!char.TryParse(Console.ReadLine(), out result)) {
            Console.WriteLine("Please enter a valid character.");
            Console.WriteLine(Enumerable.Repeat('-', Console.BufferWidth).ToArray());
            Console.WriteLine(question);
        }

        return result;
    }
}