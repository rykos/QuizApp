using System;
using System.Collections.Generic;
using System.Text;
using Questions.Models;
using System.Linq;

namespace Questions.Controllers
{
    public class QuestionController
    {
        private QuizQuestion[] _quizQuestions;
        public QuestionController(QuizQuestion[] quizQuestions)
        {
            this._quizQuestions = quizQuestions;
        }

        public QuizQuestion TakeFirstQuestion()
        {
            return _quizQuestions[0];
        }

        public string[] TakeAnswers(QuizQuestion question)
        {
            Random rnd = new Random();
            string[] res = new string[4];
            SelectIncorrectAnswers(question, 3).CopyTo(res, 0);
            res[3] = SelectRandomCorrectAnswer(question);
            return res.OrderBy(x => rnd.Next()).ToArray();
        }

        public static QuizQuestion[] SelectUniqueQuestions(QuizQuestion[] questionsPool, int amount)
        {
            Random rnd = new Random();
            List<int> usedIDs = new List<int>();
            var elgibleQuestions = questionsPool.Where(q => { return !usedIDs.Contains(q.ID); }).OrderBy(x => rnd.Next()).Take(amount);
            return elgibleQuestions.ToArray();
        }

        public static string SelectRandomCorrectAnswer(QuizQuestion question)
        {
            return question.CorrectAnswer[new Random().Next(0, question.CorrectAnswer.Length)];
        }

        public static string[] SelectIncorrectAnswers(QuizQuestion question, int amount = 3)
        {
            Random rnd = new Random();
            return question.IncorrectAnswers.OrderBy(x => rnd.Next()).Take(amount).ToArray();
        }
    }
}
