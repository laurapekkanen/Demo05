using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name + " " + Artist + " " + Price;
        }

    }
}
