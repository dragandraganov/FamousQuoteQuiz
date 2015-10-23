using FamousQuoteQuiz.Data.Repositories;
using FamousQuoteQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Data
{
    public interface IFamousQuizData
    {
        DbContext Context { get; }

        IRepository<User> Users { get; }

        void Dispose();

        int SaveChanges();
    }
}
