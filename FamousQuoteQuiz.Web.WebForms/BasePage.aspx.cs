using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Web.WebForms.Factories;

namespace FamousQuoteQuiz.Web.WebForms
{
    public abstract partial class BasePage : Ninject.Web.PageBase
    {
        public IFamousQuizData Data { get; set; }

        public IRandomFactory Factory { get; set; }

        public BasePage(IFamousQuizData data, IRandomFactory factory)
        {
            this.Data = data;
            this.Factory = factory;
        }

        protected virtual void Page_Load(object sender, EventArgs e)
        {
        }
    }
}