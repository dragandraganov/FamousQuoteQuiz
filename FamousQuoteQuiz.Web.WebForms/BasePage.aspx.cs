using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Web.WebForms.Factories;
using FamousQuoteQuiz.Common;

namespace FamousQuoteQuiz.Web.WebForms
{
    public abstract partial class BasePage : Page
    {
        public IFamousQuizData Data { get; set; }

        public IRandomFactory Factory { get; set; }

        public BasePage()
        {
            this.Data = new FamousQuizData(new FamousQuizDbContext());
            this.Factory = new RandomFactory(this.Data, new RandomGenerator());
        }

        protected virtual void Page_Load(object sender, EventArgs e)
        {
        }
    }
}