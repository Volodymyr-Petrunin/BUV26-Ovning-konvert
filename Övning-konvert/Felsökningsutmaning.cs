namespace Övning_konvert;

public class Felsökningsutmaning {
    
    //TODO Felsökningsutmaning #12
    
    /*
        Jag hittade två saker:

        1. Array använder `{ }` för värdena, vilket jag först trodde var fel.
        2. `for`-loopen saknar `{ }`, men det fungerar eftersom den bara har en rad.

        Jag hittade inte den tredje buggen.
    */

    
    public static void Main(string[] args) {
        int[] tal = [5, 10, 15, 20];
        int summa = tal.Sum();

        double medel = (double)summa / tal.Length; 
        Console.WriteLine($"Medel: {medel}");
    }
}