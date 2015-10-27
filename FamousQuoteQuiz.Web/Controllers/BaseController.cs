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
        protected IFamousQuizData Data { get; private set; }

        public BaseController(IFamousQuizData data)
        {
            this.Data = data;
        }
    }
}