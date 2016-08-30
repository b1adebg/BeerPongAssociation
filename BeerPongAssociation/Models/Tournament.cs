using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerPongAssociation.Models
{
    public class Tournament
    {
        public Tournament()
        {
            this.Participants = new HashSet<Player>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Player> Participants { get; set; }



    }
}