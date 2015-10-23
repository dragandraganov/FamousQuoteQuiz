using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AuthorViewModel> Authors { get; set; }

        public QuestionViewModel Question { get; set; }
    }
}