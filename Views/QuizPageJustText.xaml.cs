using Questions.Controllers;
using Questions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPageJustText : ContentPage
    {
        private QuestionController _questionController;
        private QuizQuestion _question;
        public QuizPageJustText(QuestionController questionController)
        {
            InitializeComponent();//Render View
            _questionController = questionController;
            _question = _questionController.TakeFirstQuestion();
            PopulateView();
        }

        private void PopulateView()
        {
            QuestionText.Text = _question.Question;
            string[] answers = _questionController.TakeAnswers(_question);
            Answer_A.Text = answers[0];
            Answer_B.Text = answers[1];
            Answer_C.Text = answers[2];
            Answer_D.Text = answers[3];
        }

        private void AnswerButtonClicked(object sender, EventArgs e)
        {
            if (_question.CorrectAnswer.Contains(((Button)sender).Text))
            {
                ((Button)sender).BackgroundColor = Color.Green;
            }
            else
            {
                ((Button)sender).BackgroundColor = Color.Red;
            }
        }
    }
}