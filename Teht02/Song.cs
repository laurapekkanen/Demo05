using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Song : CD
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }

        public override string ToString()
        {
            return base.ToString() + Number + " " + Title + " " + Length;
        }
    }
}
