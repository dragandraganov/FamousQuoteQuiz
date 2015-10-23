using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Models
{
    public class Author
    {
        public Author()
        {
            this.Questions = new HashSet<Question>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(450)]
        [Index(IsUnique = true)]
        public string FullName { get; set; }

        public virtual IEnumerable<Question> Questions { get; set; }
    }
}
