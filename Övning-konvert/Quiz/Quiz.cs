namespace Övning_konvert;

//TODO Math quiz #10

public class Quiz {

    private static readonly Random Random = new Random();
    
    public static void Main(string[] args) {
        Console.WriteLine("How many questions do you want to answer?");
        int amountOfQuestions = int.Parse(Console.ReadLine());
        
        List<Question> questions = generateQuestions(amountOfQuestions);

        int correctAnswers = questions.Count(CheckAnswer);
        
        Console.WriteLine($"You got {correctAnswers} out of {questions.Count} correct");
    }

    private static List<Question> generateQuestions(int amount) {
        var questions = new List<Question>();

        for (int index = 0; index < amount; index++) {
            int firstNumber = Random.Next(1, 21);
            int secondNumber = Random.Next(1, 11);
        
            char mathSymbol = GetRandomMathSymbol(secondNumber);
            
            questions.Add(new Question(firstNumber, secondNumber, mathSymbol));
        }
        
        return questions;
    }
    
    private static char GetRandomMathSymbol(int secondNumber) {
        int randomNumber = Random.Next(1, 5);
        
        if (secondNumber is 0 && randomNumber is 4) {
            return '*';
        }

        return randomNumber switch {
            1 => '-',
            2 => '+',
            3 => '*',
            4 => '/',
            _ => '?',
        };
    }

    private static bool CheckAnswer(Question  question) {
        Console.Write(question.ToString() + "=");
        int input = int.Parse(Console.ReadLine());

        return input.Equals(question.GetResult());
    }
}