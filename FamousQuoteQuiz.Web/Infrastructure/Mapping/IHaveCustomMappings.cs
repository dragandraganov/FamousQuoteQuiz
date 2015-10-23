using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamousQuoteQuiz.Web.Infrastructure.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}