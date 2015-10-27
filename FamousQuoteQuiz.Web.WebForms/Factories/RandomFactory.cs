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
    public class RandomFactory : IRandomFactory
    {
        private IFamousQuizData data;

        private IRandomGenerator generator;

        public RandomFactory(IFamousQuizData data, IRandomGenerator generator)
        {
            this.data = data;
            this.generator = generator;
        }

        public QuestionModel GetRandomQuestion()
        {
            var questionsIds = this.data.Questions
                 .All()
                 .Select(q => q.Id)
                 .ToList();

            var randomIndex = generator.GetRandomNumber(0, questionsIds.Count() - 1);

            var randomQuestionId = questionsIds[randomIndex];

            var randomQuestion = this.data.Questions
                .All()
                .Where(q => q.Id == randomQuestionId)
                .ProjectTo<QuestionModel>()
                .FirstOrDefault();

            return randomQuestion;
        }

        public int GetRandomAuthorId(IList<int> authorIds)
        {
            var randomIndex = this.generator.GetRandomNumber(0, authorIds.Count - 1);
            var randomAuthorId = authorIds[randomIndex];

            return randomAuthorId;
        }

    }
}