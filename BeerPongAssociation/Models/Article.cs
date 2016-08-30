using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPongAssociation.Models
{
    public class Article
    {
        public Article()
        {
            this.Tags = new HashSet<Tag>();
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }


    }
}