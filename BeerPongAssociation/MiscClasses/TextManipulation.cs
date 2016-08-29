using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPongAssociation.MiscClasses
{
    public class TextManipulation
    {
        public static string ShortenText(string text, int maxLenght = 100)
        {
            if (text == null || text.Length <= maxLenght)
            {
                return text;
            }

            string cutText = text.Substring(0, maxLenght) + "...";
            return cutText;
        }
    }
}