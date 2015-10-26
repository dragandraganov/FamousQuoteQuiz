using FamousQuoteQuiz.Models;
using FamousQuoteQuiz.Web.WebForms.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.WebForms.Models
{
    public class AuthorModel : IMapFrom<Author>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Author, AuthorModel>()
                 .ReverseMap();
        }
    }
}