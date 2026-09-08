namespace Övning_konvert;

public class Calculator {
    //TODO: Implementera en kalkylator #5
    
    // public static void Main(string[] args) {
    //     Console.WriteLine("Welcome to calculator");
    //     double firstNumber = GetValidNumberInput("Enter first number: ");
    //     double secondNumber = GetValidNumberInput("Enter second number: ");
    //     char operation = GetValidCharInput("Please enter a valid operation (+, -, *, /): ");
    //
    //     try {
    //         double result = operation switch
    //         {
    //             '+' => firstNumber + secondNumber,
    //             '-' => firstNumber - secondNumber,
    //             '*' => firstNumber * secondNumber,
    //             '/' => Divide(firstNumber, secondNumber),
    //         };
    //         Console.WriteLine($"Result: {result}");
    //     } catch (Exception e) {
    //         Console.WriteLine(e.Message);
    //     }
    // }
    
    private static double GetValidNumberInput(string question) {
        Console.WriteLine(question);
        double result;
        
        while (!double.TryParse(Console.ReadLine(), out result)) {
            Console.WriteLine("Please enter a valid number.");
        }

        return result;
    }
    
    private static char GetValidCharInput(string question) {
        Console.WriteLine(question);
        char result;

        while (!char.TryParse(Console.ReadLine(), out result)) {
            Console.WriteLine("Please enter a valid character.");
            Console.WriteLine(question);
        }

        return result;
    }

    private static double Divide(double firstNumber, double secondNumber) {
        if (secondNumber == 0) {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        
        return firstNumber / secondNumber;
    }
}