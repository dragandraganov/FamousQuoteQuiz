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
            var model = new HomeViewModel();

            var randomQuestion = GetRandomQuestion();

            var authorIds = this.Data.Authors
                .All()
                .Select(a => a.Id)
                .ToList();

            var randomAuthorIds = new HashSet<int>();
            randomAuthorIds.Add(randomQuestion.AuthorId);

            while (randomAuthorIds.Count() < GlobalConstants.NumberOfAuthorsToChoose)
            {
                var randomIndex = generator.GetRandomNumber(0, authorIds.Count());
                var randomAuthorId = authorIds[randomIndex];
                randomAuthorIds.Add(randomAuthorId);
            }

            var authors = this.Data.Authors
                .All()
                .Where(a => randomAuthorIds.Contains(a.Id))
                .ProjectTo<AuthorViewModel>()
                .ToList()
                .OrderBy(a => a.FullName);

            model.Question = randomQuestion;
            model.Authors = authors;

            return View(model);
        }

        private QuestionViewModel GetRandomQuestion()
        {
            var questionsIds = this.Data.Questions
                .All()
                .Select(q => q.Id)
                .ToList();

            var randomIndex = generator.GetRandomNumber(0, questionsIds.Count());

            var randomQuestionId = questionsIds[randomIndex];

            var randomQuestion = this.Data.Questions
                .All()
                .Where(q => q.Id == randomQuestionId)
                .ProjectTo<QuestionViewModel>()
                .FirstOrDefault();

            return randomQuestion;
        }

        [HttpPost]
        public ActionResult IsUserChoiseCorrect(int questionId, int authorId)
        {
            var isAnswerCorrect = false;
            var question = this.Data.Questions.All().FirstOrDefault(q => q.Id == questionId);

            if (question.AuthorId == authorId)
            {
                isAnswerCorrect = true;
            }

            var model = new Tuple<string, bool>(question.Author.FullName, isAnswerCorrect);

            return PartialView("_ResultView", model);
        }
    }
}