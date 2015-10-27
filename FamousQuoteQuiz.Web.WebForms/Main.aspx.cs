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
using System.Web.Services;
using System.Web.Script.Services;

namespace FamousQuoteQuiz.Web.WebForms
{
    public partial class Main : BasePage
    {
        protected override void Page_Load(object sender, EventArgs e)
        {
            var randomQuestion = this.Factory.GetRandomQuestion();
            hidden_questionId.ID = "questionId-" + randomQuestion.Id;
            description.Controls.Add(new LiteralControl(randomQuestion.Description));

            var author = this.Factory.GetRandomAuthor();

            hidden_authorId.ID = "author.Id-" + author.Id;
            author_name.Controls.Add(new LiteralControl(String.Format("{0}?", author.FullName)));

            var randomAuthors = this.Factory.GetRandomAuthors(randomQuestion.AuthorId);
            authors_list.DataSource = randomAuthors;
            authors_list.DataBind();
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static Tuple<bool, string> IsUserChoiseCorrect(int questionId, int authorId, bool isAnswerCorrect)
        {
            var data = new FamousQuizData(new FamousQuizDbContext());

            var question = data.Questions
                .All()
                .FirstOrDefault(q => q.Id == questionId);

            isAnswerCorrect = !((question.AuthorId == authorId) ^ isAnswerCorrect);

            return new Tuple<bool, string>(isAnswerCorrect, question.Author.FullName);
        }
    }
}