using System.ComponentModel.DataAnnotations;

namespace BeerPongAssociation.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}