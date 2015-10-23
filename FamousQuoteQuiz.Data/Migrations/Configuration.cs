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
        private UserManager<User> userManager;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // TODO: Return to false in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FamousQuoteQuiz.Data.FamousQuizDbContext context)
        {
            if (context.Users.FirstOrDefault(u => u.Email == "admin@com.com") == null)
            {
                this.userManager = new UserManager<User>(new UserStore<User>(context));

                if (context.Roles.FirstOrDefault(r => r.Name == GlobalConstants.AdminRole) == null)
                {
                    var adminRole = new IdentityRole(GlobalConstants.AdminRole);
                    context.Roles.Add(adminRole);
                    context.SaveChanges();
                }

                var user = new User();
                user.UserName = "admin";
                user.Email = "admin@com.com";
                this.userManager.Create(user, "111111");
                this.userManager.AddToRole(user.Id, GlobalConstants.AdminRole);
                context.SaveChanges();
            }
        }
    }
}
