/// <summary>
/// Assignment 11: quiz application. It contains loads of MCQs (Multiple Choice Questions).
/// </summary>
class Program
{
    static void Main()
    {
        //Create an object of Question class and pass no arguments to the constructor
        Question question1 = new Question();
        System.Console.WriteLine(question1.correctAnswerLetter);

        //Create an object of Question class and pass value for questionText only to the constructor.
        Question question2 = new Question("In which continent is Costa Rica situated?");
        System.Console.WriteLine(question2.correctAnswerLetter);

        //Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        Question question3 = new Question("In which continent is Costa Rica situated?", "Asia", "North America", "Central America", "South America", 'C');
        System.Console.WriteLine(question3.correctAnswerLetter);

        //Create an object for Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        Question question4 = new Question() { questionText = "In which continent is Costa Rica situated?", optionA = "Asia", optionB = "North America", optionC = "Central America", optionD = "South America", correctAnswerLetter = 'C' };
        System.Console.WriteLine(question4.correctAnswerLetter);

        System.Console.Write("Enter any key to end program: ");
        System.Console.ReadKey();
    }
}

