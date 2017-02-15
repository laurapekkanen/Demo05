using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kissi = new Cat
            { Name = "Kissi", Breed = "Persian", Weight = 6.6, Color = "Gray", FaveFood = "Lasagna", CrazyLevel = 5 };
            Cat kissimissi = new Cat
            { Name = "Kissimissi", Breed = "Ragdoll", Weight = 5.1, Color = "White", FaveFood = "Cat food", CrazyLevel = 8 };
            Cat garmisch_partenkirchen = new Cat
            { Name = "Garmisch-Partenkirchen", Breed = "Siamese", Weight = 3.7, Color = "Brown", FaveFood = "Fish", CrazyLevel = 2 };

            Cats kissit = new Cats();
            kissit.AddCat(kissi);
            kissit.AddCat(kissimissi);
            kissit.AddCat(garmisch_partenkirchen);

            kissit.PrintCollection();
        }
    }
}
