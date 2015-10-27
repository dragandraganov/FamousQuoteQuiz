using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Web.WebForms.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FamousQuoteQuiz.Web.WebForms.UserControls
{
    public partial class BinaryMode : BasePage
    {

        public BinaryMode(IFamousQuizData data, IRandomFactory factory)
            : base(data, factory)
        {
        }

        protected override void Page_Load(object sender, EventArgs e)
        {
            var authorIds = this.Data.Authors
               .All()
               .Select(a => a.Id)
               .ToList();

            var randomAuthorId = this.Factory.GetRandomAuthorId(authorIds);
        }
    }
}