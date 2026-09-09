namespace Övning_konvert;

public class OutOfAgeException : Exception {
    public OutOfAgeException() {
    }
    
    public OutOfAgeException(string message) : base(message) {
    }
}