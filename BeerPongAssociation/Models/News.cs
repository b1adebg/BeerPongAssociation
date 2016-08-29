using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerPongAssociation.Models
{
    public class News
    {
        public News()
        {
            this.Date = DateTime.Now;
            this.Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}