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
    public class FamousQuizDbContext : IdentityDbContext<User>
    {
        public FamousQuizDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FamousQuizDbContext, Configuration>());
        }

        public static FamousQuizDbContext Create()
        {
            return new FamousQuizDbContext();
        }
    }
}
