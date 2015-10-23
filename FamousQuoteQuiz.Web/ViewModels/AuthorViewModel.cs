using FamousQuoteQuiz.Models;
using FamousQuoteQuiz.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.ViewModels
{
    public class AuthorViewModel : IMapFrom<Author>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Question, QuestionViewModel>()
                 .ReverseMap();
        }
    }
}