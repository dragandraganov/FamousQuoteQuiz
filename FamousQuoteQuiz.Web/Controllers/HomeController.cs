using FamousQuoteQuiz.Common;
using FamousQuoteQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using FamousQuoteQuiz.Web.ViewModels;

namespace FamousQuoteQuiz.Web.Controllers
{
    public class HomeController : BaseController
    {
        private RandomGenerator generator;
        public HomeController(FamousQuizData data)
            : base(data)
        {
            this.generator = new RandomGenerator();
        }

        public ActionResult Index()
        {
            var questionsIds = this.Data.Questions.All().Select(q => q.Id).ToList();
            var randomIndex = generator.GetRandomNumber(0, questionsIds.Count());
            var randomQuestionId = questionsIds[randomIndex];

            var randomQuestion = this.Data.Questions
                .All()
                .Where(q => q.Id == randomQuestionId)
                .Project()
                .To<QuestionViewModel>()
                .FirstOrDefault();

            return View(randomQuestion);
        }
    }
}