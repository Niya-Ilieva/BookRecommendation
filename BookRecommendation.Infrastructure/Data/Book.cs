using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Infrastructure.Data
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


        [Required]
        [StringLength(200)]
        public string BookName { get; set; }

        public int Likes { get; set; }


        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }


        public string Username { get; set; }


        public List<Genre> Genres { get; set; } = new List<Genre>();
    }
}
