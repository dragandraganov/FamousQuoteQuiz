using FamousQuoteQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamousQuoteQuiz.Web.Controllers
{
    public class BaseController : Controller
    {
        private FamousQuizData data;

        protected FamousQuizData Data { get; private set; }

        public BaseController(FamousQuizData data)
        {
            this.Data = data;
        }
    }
}