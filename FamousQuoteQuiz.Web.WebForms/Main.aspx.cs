using FamousQuoteQuiz.Common;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Web.WebForms.Factories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FamousQuoteQuiz.Web.WebForms
{
    public partial class Main : BasePage
    {
        [Inject]
        public IRandomFactory factory { get; set; }

        protected override void Page_Load(object sender, EventArgs e)
        {
            var randomQuestion = factory.GetRandomQuestion();
            description.Controls.Add(new LiteralControl(randomQuestion.Description));
        }
    }
}