using FamousQuoteQuiz.Common;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;
using System.Collections;

namespace FamousQuoteQuiz.Web.Infrastructure.Factories
{
    public class RandomFactory : IRandomFactory
    {
        private IRandomGenerator generator;

        private IFamousQuizData data;

        public RandomFactory(IFamousQuizData data, IRandomGenerator generator)
        {
            this.generator = generator;
            this.data = data;
        }

        public QuestionViewModel GetRandomQuestion()
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
                .ProjectTo<QuestionViewModel>()
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