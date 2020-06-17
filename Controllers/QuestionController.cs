using System;
using System.Collections.Generic;
using System.Text;
using Questions.Models;
using System.Linq;

namespace Questions.Controllers
{
    class QuestionController
    {
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

        public static string[] SelectIncorrectAnswers(QuizQuestion question)
        {
            Random rnd = new Random();
            return question.IncorrectAnswers.OrderBy(x => rnd.Next()).ToArray();
        }
    }
}
