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
    public class FamousQuizData : IFamousQuizData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public FamousQuizData(DbContext context)
        {
            this.context = context;
        }
        public DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public IRepository<User> Users
        {

            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Question> Questions
        {
            get
            {
                return this.GetRepository<Question>();
            }
        }

        public IRepository<Author> Authors
        {
            get
            {
                return this.GetRepository<Author>();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

    }
}
