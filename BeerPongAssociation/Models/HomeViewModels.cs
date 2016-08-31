using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPongAssociation.Models
{
    public class WelcomeViewModel
    {
        public List<News> LatestNews { get; set; }

        public Article LastArticle { get; set; }

        public Tournament FeaturedTournament { get; set; }

        public Player FeaturedPlayer { get; set; }
    }
}