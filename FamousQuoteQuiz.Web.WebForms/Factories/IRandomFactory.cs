using FamousQuoteQuiz.Web.WebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.WebForms.Factories
{
    public interface IRandomFactory
    {
        QuestionModel GetRandomQuestion();

        int GetRandomAuthorId(IList<int> authorIds);
    }
}