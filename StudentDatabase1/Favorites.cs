using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase1
{
    public class Favorites
    {
        public string Food { get; set; }
        public string Color { get; set; }
        public string Movie { get; set; }
        public string Book { get; set; }

        public Favorites(string food, string color, string movie, string book)
        {
            Food = food;
            Color = color;
            Movie = movie;
            Book = book;
        }

        public string FavoriteCategorie(string category)
        {

            switch (category)
            {
                case "food": return $"The favorite food is {category}";
                case "color": return $"The favorite color is {category}";
                case "movie": return $"The favorite movie is {category}";
                case "book": return $"The favorite book is {category}";

            }
            return "You did not enter a valid categorie";

        }
    }
}
