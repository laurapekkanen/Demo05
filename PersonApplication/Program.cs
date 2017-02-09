using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create few person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "123456-0000"
            };

            Person person2 = new Person
            {
                Firstname = "Pekka",
                Lastname = "Routalempi",
                SocialSecurityNumber = "223344-6789"
            };

            Person person3 = new Person
            {
                Firstname = "Kyösti",
                Lastname = "Pöysti",
                SocialSecurityNumber = "101020-1234"
            };

            // create a Persons object
            Persons myFriends = new Persons();

            //add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = myFriends.GetPerson(100);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "123456-0002";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Cant find person with that sotu");
            }
        }
    }
}
