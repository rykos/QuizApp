using System.Collections.Generic;
using Xamarin.Forms;
using Answers.Models;

namespace Questions.Models
{
    class QuizQuestion
    {
        public int ID { get; set; }
        public string Question { get; set; }//Always
        public string[] CorrectAnswer { get; set; }//Always, either just string or path to image
        public string[] IncorrectAnswers { get; set; }//Always, same as CorrectAnswer
        public QuestionType QuestionType { get; set; }//Always
    }

    enum QuestionType
    {
        JustText,
        JustImages,
        Hybrid
    }
}
