using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
