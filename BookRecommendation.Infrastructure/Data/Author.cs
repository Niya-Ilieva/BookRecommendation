using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Infrastructure.Data
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string AuthorName { get; set; }


        public List<Book> Books { get; set; } = new List<Book>();

        public List<Quote> Quotes { get; set; } = new List<Quote>();
    }
}
