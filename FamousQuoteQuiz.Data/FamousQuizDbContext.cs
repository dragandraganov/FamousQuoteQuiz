using FamousQuoteQuiz.Data.Migrations;
using FamousQuoteQuiz.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Data
{
    public class FamousQuizDbContext : DbContext
    {
        public FamousQuizDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FamousQuizDbContext, Configuration>());
        }

        public virtual IDbSet<Question> Questions { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public static FamousQuizDbContext Create()
        {
            return new FamousQuizDbContext();
        }
    }
}
