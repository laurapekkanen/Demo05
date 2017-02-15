using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string FaveFood { get; set; }
        public int CrazyLevel { get; set; }

        public override string ToString()
        {
            return "Cat info: " + "\nname: " + Name + "\nbreed: " + Breed + "\nweight: " + Weight + "\ncolor: " + Color + "\nfave food: " + FaveFood + "\ncrazy level:  " + CrazyLevel;
        }
    }
}
