using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APQiuzAPP.Models{
public class QuizModel{

        [Required]
         public int Id { get; set;}
        [Column ("QuestionText")]
      public string QuestionText { get; set; } = string.Empty;
      [Column ("Option01Text")]
        public string Option01Text { get; set; } = string.Empty;
         [Column ("Option02Text")]
        public string Option02Text { get; set; } = string.Empty;
         [Column ("Option03Text")]
        public string Option03Text { get; set; } = string.Empty;
         [Column ("Option04Text")]
        public string Option04Text { get; set; } = string.Empty;
         [Column ("CorrectAnswerText")]
        public string CorrectAnswerText { get; set; } = string.Empty;


        public string Columns()
        {
            return $"QuestionText|Option01Text|Option02Text|Option03Text|Option04Text|CorrectAnswerText";
        }

        public override string ToString()
        {
            return$"QuestionText|Option01Text|Option02Text|Option03Text|Option04Text|CorrectAnswerText";
        }

        public QuizModel()
        {

        }

        public QuizModel(string lineRead)
        {
            string[] lineReadArray = lineRead.Split("|");
            Id = Convert.ToInt32(lineReadArray[0]);
            QuestionText = lineReadArray[1];
            Option01Text = lineReadArray[2];
            Option02Text = lineReadArray[3];
            Option03Text = lineReadArray[4];
            Option04Text = lineReadArray[5];


        }
        
}

}