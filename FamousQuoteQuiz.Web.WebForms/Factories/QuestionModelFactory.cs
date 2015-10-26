using FamousQuoteQuiz.Common;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Models;
using FamousQuoteQuiz.Web.WebForms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;

namespace FamousQuoteQuiz.Web.WebForms.Factories
{
    public class QuestionModelFactory
    {
        private static FamousQuizData data = new FamousQuizData(new FamousQuizDbContext());

        private static RandomGenerator generator = new RandomGenerator();

        public static QuestionModel GetRandomQuestion()
        {
            var questionsIds = data.Questions
                .All()
                .Select(q => q.Id)
                .ToList();

            var randomIndex = generator.GetRandomNumber(0, questionsIds.Count() - 1);

            var randomQuestionId = questionsIds[randomIndex];

            var randomQuestion = data.Questions
                .All()
                .Where(q => q.Id == randomQuestionId)
                .ProjectTo<QuestionModel>()
                .FirstOrDefault();

            return randomQuestion;
        }
    }
}