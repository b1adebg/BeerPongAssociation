using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerPongAssociation.Models
{
    public class Tag
    {
        public Tag()
        {
            this.NewsTagged = new HashSet<News>();
            this.ArticlesTagged = new HashSet<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<News> NewsTagged { get; set; }

        public virtual ICollection<Article> ArticlesTagged { get; set; }

    }
}