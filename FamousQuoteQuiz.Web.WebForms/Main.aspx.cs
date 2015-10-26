using FamousQuoteQuiz.Web.WebForms.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FamousQuoteQuiz.Web.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var randomQuestion = QuestionModelFactory.GetRandomQuestion();
            description.Text = randomQuestion.Description;
        }
    }
}