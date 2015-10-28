namespace FamousQuoteQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using FamousQuoteQuiz.Models;
    using FamousQuoteQuiz.Common;
    using FamousQuoteQuiz.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<FamousQuizDbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // TODO: Return to false in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FamousQuoteQuiz.Data.FamousQuizDbContext context)
        {
        }
    }
}
