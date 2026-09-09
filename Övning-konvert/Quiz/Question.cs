namespace Övning_konvert;

public class Question(int firstNumber, int secondNumber, char mathOperator) {
    private int FirstNumber { get; set; } = firstNumber;

    private int SecondNumber { get; set; } = secondNumber;

    private char MathOperator { get; set; } = mathOperator;

    public override string ToString() {
        return firstNumber.ToString() + mathOperator + secondNumber.ToString();
    }

    public int GetResult() {
        return mathOperator switch
        {
            '+' => FirstNumber + SecondNumber,
            '-' => FirstNumber - SecondNumber,
            '*' => FirstNumber * SecondNumber,
            '/' => FirstNumber / SecondNumber,
            _ => throw new InvalidDataException(),
        };
    }
}