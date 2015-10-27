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
    public class SettingsController : BaseController
    {
        public SettingsController(IFamousQuizData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}