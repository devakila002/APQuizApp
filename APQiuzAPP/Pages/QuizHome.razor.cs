using APQiuzAPP.Models;
namespace APQiuzAPP.Pages
{

    public partial class QuizHome
    {
        const string    FILEQUIZENTRIES = " MyQuizEntries.txt";

        private Random random = new Random();

        public QuizQuestion Model { get; set;} = new QuizQuestion();

        public List<QuizModel> QuizEntries = new List<QuizModel>();

        public QuizHome()
        {
            if(File.Exists(FILEQUIZENTRIES))
            {
                using (StreamReader sr = new StreamReader(FILEQUIZENTRIES))
                {
                    string lineRead = sr.ReadLine();
                    lineRead = sr.ReadLine();
                    while (!string.IsNullOrEmpty(lineRead))
                    {
                        if(lineRead.Contains("|"))
                        {
                            QuizModel quizModel = new QuizModel(lineRead);
                            QuizEntries.Add(quizModel);
                        }
                        lineRead = sr.ReadLine();
                    }
                }
            }
        }
            void SaveEntry()
          {
            Console.WriteLine($"Saving Entry {Model}");
            QuizModel newRow = new QuizModel();
           // newRow.Id = Model.Id;
            newRow.QuestionText = Model.QuestionText;
            newRow.Option01Text = Model.Option01Text;
            newRow.Option02Text = Model.Option02Text;
             newRow.Option03Text = Model.Option03Text;
             newRow.Option04Text = Model.Option04Text;
            QuizEntries.Add(newRow);
        }
      

        void PersistAllEntries()
        {
           
            using (QuizContext quizContext = new QuizContext())
            {                
                int blogCount = random.Next(1000,1000000); // ttContext.Blogs ttContext.Blogs.Count();
                quizContext.Blogs.Add(new Blog(){ Url = $"https://blognumber{blogCount}"});
                quizContext.SaveChanges();
            }

            using (StreamWriter sw = new StreamWriter(FILEQUIZENTRIES))
            {
                sw.WriteLine(new QuizModel().Columns());
                foreach (var QuizEntry in QuizEntries)
                {
                    sw.WriteLine(QuizEntry);
                }
            }
        }



        public bool HideButtonStartQuiz { get; set; } = false; //1
        public bool HideQustionPanel { get; set; } = true; //2
        public bool HideAnswerPanel { get; set; } = true; //3
        public bool HideButtonQuitQuiz { get; set; } = true; //4
        public bool HideButtonQuit { get; set; } = false; //5 buttons
        QuizQuestion currentQuestion = new QuizQuestion();
        string userSelectedAnswer = string.Empty;
        string userResult = string.Empty;
        public int questionNumberToShow = 0;

        QuizQuestion q1 = new QuizQuestion()
        {
            QuestionText = "What is TDD?",
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
            HideButtonQuit = true;
            HideButtonQuitQuiz = false;
            IncrementQuestionNumber();
            NextQuestion();


        }



        public void VerifyAnswer()
        {
            CheckAnswer();
                     
      
        }

        public bool CheckAnswer()
        {
            bool isEnteredAns = false;
            if (userSelectedAnswer == currentQuestion.CorrectAnswerText)
            {
                userResult = "Wow!!! Correct Answer";
                isEnteredAns = true;
            }
            else
            {
                userResult = "Sorry Its Wrong Answer" + currentQuestion.CorrectAnswerText;
            }
            HideAnswerPanel = false;
            return isEnteredAns;
        }

        public void NextQuestion()
        {
            if (questionNumberToShow == 1) { currentQuestion = q1; }
            else if (questionNumberToShow == 2) { currentQuestion = q2; }
            else if (questionNumberToShow == 3) { currentQuestion = q3; }
            else if (questionNumberToShow == 4) { currentQuestion = q4; }
            else if (questionNumberToShow == 5) { currentQuestion = q5; }
            else
            {
                currentQuestion = new QuizQuestion();
                questionNumberToShow = 0;
            }
        }
        public void IncrementQuestionNumber()
        {
            if (CheckAnswer() || questionNumberToShow == 0)
            {
                questionNumberToShow = questionNumberToShow + 1; //1
            }
            NextQuestion();
            HideAnswerPanel = true;
        }
        public void QuitQuiz()
        {
            currentQuestion = new QuizQuestion();
            questionNumberToShow = 0;
            HideButtonStartQuiz = false;
            HideButtonQuitQuiz = true;
            HideQustionPanel = true;
            HideButtonQuit = false;

        }
        public void Quit()
        {
            Navimnger.NavigateTo("/");
            HideQustionPanel = true;
        }


    }
}