using FamousQuoteQuiz.Models;
using FamousQuoteQuiz.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.ViewModels
{
    public class QuestionViewModel : IMapFrom<Question>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string AuthorName { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Question, QuestionViewModel>()
                .ForMember(m => m.AuthorName, opt => opt.MapFrom(q => q.Author.FullName))
                .ReverseMap();
        }
    }
}