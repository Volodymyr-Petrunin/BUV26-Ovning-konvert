using Microsoft.VisualBasic;
using static System.Int32;

namespace Övning_konvert;

class Program {
    
    //TODO: Implementera konverteringar #1
    
    // static void Main(string[] args) {
    //     Console.Write("Write temperature in Celsius: ");
    //     var celsius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    //     var fahrenheit = celsius * 9 / 5 + 32;
    //     Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");
    // }

    //TODO: Implementera TryParse #2
    
    // public static void Main(string[] args) {
    //     Console.Write("Write a number: ");
    //     bool isParse = int.TryParse(Console.ReadLine(), out int number);
    //
    //     if (!isParse) {
    //         Console.WriteLine("Not a number");
    //     }
    // }

    //TODO: Implementera Random #3
    
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
    
    //TODO Guess a number #6
    
    // public static void Main(string[] args) {
    //     var random = new Random();
    //     int number = random.Next(1, 101);
    //     int tries = 1;
    //
    //     int userGuess = GetUserGuess();
    //     
    //     while (userGuess != number) {
    //         Console.WriteLine(userGuess < number ? "Högre" : "Lägre");
    //         
    //         tries++;
    //         userGuess = GetUserGuess();
    //     }
    //     
    //     Console.WriteLine($"You guessed the number in {tries} tries");
    // }
    //
    // private static int GetUserGuess() {
    //     Console.Write("Guess a number between 1 and 100: ");
    //     int userGuess = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    //     return userGuess;
    // }
    
    //TODO Var vs Dynamic #7

    // public static void Main(string[] args) {
    //     var numberAsInt = 10;
    //     var numberAsDouble = 10.0;
    //     var numberAsString = "10";
    //     
    //     dynamic number = 10;
    //     Console.WriteLine(number.GetType());
    //     number = "10";
    //     Console.WriteLine(number.GetType());
    //     number = 10.0;
    //     Console.WriteLine(number.GetType());
    //
    //     Console.WriteLine(new string('-', 50));
    //     Console.WriteLine(numberAsInt + numberAsDouble + numberAsString);
    //
    //     number.Add(numberAsInt);
    // }

    //TODO Registration System #9
    
    // public static void Main(string[] args) {
    //     Console.WriteLine("Hi, what is your name?");
    //     string name = Console.ReadLine();
    //
    //     Console.WriteLine("Hello " + name + " Whats is your age?");
    //     bool isAgeValid = TryParse(Console.ReadLine(), out int age);
    //
    //     if (!isAgeValid || age is < 0 or > 120) {
    //         throw new OutOfAgeException("Your age must be between 0 and 120 and not contains any characters");
    //     }
    //     
    //     Console.WriteLine("Nice, what is your salary");
    //     bool isSalaryValid = TryParse(Console.ReadLine(), out int salary);
    //
    //     if (!isSalaryValid || salary is < 0 or > 100000) {
    //         throw new InvalidDataException("Your salary must be between 0 and 100000");
    //     }
    //
    //     Console.WriteLine("Your account is registered successfully");
    // }
}