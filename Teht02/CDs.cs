using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CDs
    {
        //collection
        private List<CD> cds;

        //default constructor
        public CDs()
        {
            cds = new List<CD>();
        }

        //add cd to list
        public void AddCd(CD cd)
        {
            cds.Add(cd);
        }

        //print list
        public void PrintCollection()
        {
            foreach (CD cd in cds)
            {
                Console.WriteLine(cd.ToString());
            }

        }
    }
}
