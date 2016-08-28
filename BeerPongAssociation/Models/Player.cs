using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPongAssociation.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [Required]
        [StringLength(20)]
        public string PlayerClass { get; set; }

        public int LeftHandPrecision { get; set; }

        public int RightHandPrecision { get; set; }

        public int Stamina { get; set; }

        public int Mentality { get; set; }

        [StringLength(100)]
        public string BestResult { get; set; }

        [Required]
        public string ProfessionalCareer { get; set; }

        [Required]
        public string PersonalIfno { get; set; }

        public int Popularity { get; set; }

        public ApplicationUser UserAccount { get; set; }

        public string PicturePath { get; set; }
    }
}