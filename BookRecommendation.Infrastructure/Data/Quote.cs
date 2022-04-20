using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Infrastructure.Data
{
    public class Quote
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

       
        [Required]
        [StringLength(3000)]
        public string QuoteText { get; set; }
        
        public Guid AuthorId { get; set; }

        
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }


        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(200)]
        public string BookName { get; set; }
    }
}
