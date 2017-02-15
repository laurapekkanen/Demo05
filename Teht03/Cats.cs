using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Cats
    {
        //collection
        private List<Cat> cats;

        //default constructor
        public Cats()
        {
            cats = new List<Cat>();
        }

        //add cat to list
        public void AddCat(Cat cat)
        {
            cats.Add(cat);
        }

        //print list
        public void PrintCollection()
        {
            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat.ToString());
            }

        }
    }
}
