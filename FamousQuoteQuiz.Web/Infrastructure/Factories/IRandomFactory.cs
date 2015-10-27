using FamousQuoteQuiz.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.Infrastructure.Factories
{
    public interface IRandomFactory
    {
        QuestionViewModel GetRandomQuestion();

        int GetRandomAuthorId(IList<int> authorIds);
    }
}