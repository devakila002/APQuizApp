using APQiuzAPP.Models;
namespace APQiuzAPP.Pages
{

public partial class QuizHome 
{
    public bool HideButtonStartQuiz {get; set;} = false;

    public bool HideQustionPanel { get; set; } = true;

    QuizQuestion currentQuestion = new QuizQuestion();

    string userTextToShow = string.Empty;

    QuizQuestion q1 = new QuizQuestion()
        {
            QuestionText = "1 .What is TDD?",
            Option01Text = "Test Driving Destination",
            Option02Text = "Test Driven Driving",
            Option03Text = "Test Driven Development",
            Option04Text = "Testing Development Design",
            CorrectAnswerText = "Test Driven Development"
        };
        QuizQuestion q2 = new QuizQuestion()
        {
            QuestionText = "What is MVC?",
            Option01Text = "Test Driving Destination",
            Option02Text = "Test Driven Driving",
            Option03Text = "Test Driven Development",
            Option04Text = "Model View Controler",
            CorrectAnswerText = "Model View Controler"
        };
        QuizQuestion q3 = new QuizQuestion()
        {
            QuestionText = "What is SSH",
            Option01Text = "SecureShell",
            Option02Text = "Test Driven Driving",
            Option03Text = "Test Driven Development",
            Option04Text = "Testing Development Design",
            CorrectAnswerText = "SecureShell"
        };
        QuizQuestion q4 = new QuizQuestion()
        {
            QuestionText = "What is URL",
            Option01Text = "Test Driving Destination",
            Option02Text = "Uniform Resoruce Locator",
            Option03Text = "Test Driven Development",
            Option04Text = "Testing Development Design",
            CorrectAnswerText = "Uniform Resoruce Locator"
        };
        QuizQuestion q5 = new QuizQuestion()
        {
            QuestionText = "What is Razor?",
            Option01Text = "Test Driving Destination",
            Option02Text = "Test Driven Driving",
            Option03Text = "Test Driven Development",
            Option04Text = "Syntax both html element and c# code",
            CorrectAnswerText = "Syntax both html element and c# code"
        };

    public void StartQuiz()
    {
        HideButtonStartQuiz = true;
        HideQustionPanel = false;

    }
}

}