using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD afterlife = new CD
            { Name = "Afterlife", Artist = "Disco Ensemble", Price = 19.99 };
            Song reality = new Song
            { Number = 1, Title = "Reality", Length = "4 min 13 s" };
            Song fight_forever = new Song
            { Number = 2, Title = "Fight Forever", Length = "3 min 59 s" };
            Song disppear = new Song
            { Number = 3, Title = "Disappear", Length = "3 min 41 s" };
            Song afterlife_song = new Song
            { Number = 4, Title = "Afterlife", Length = "4 min 34 s" };
            Song nothing_more = new Song
            { Number = 5, Title = "Nothing More", Length = "3 min 40 s" };
            Song das_boot = new Song
            { Number = 6, Title = "Das Boot", Length = "3 min 44 s" };
            Song hardcore_people = new Song
            { Number = 7, Title = "Hardcore People", Length = "3 min 26 s" };
            Song face_down_in_a_fountain = new Song
            { Number = 8, Title = "Face Down in a Fountain", Length = "2 min 51 s" };
            Song surround_me = new Song
            { Number = 9, Title = "Surround Me", Length = "4 min 9 s" };
            Song too_deep = new Song
            { Number = 10, Title = "Too Deep", Length = "3 min 56 s" };
            Song midnight = new Song
            { Number = 11, Title = "Midnight", Length = "4 min" };

            Songs de_afterlife = new Songs();
            de_afterlife.AddSong(reality);
            de_afterlife.AddSong(fight_forever);
            de_afterlife.AddSong(disppear);
            de_afterlife.AddSong(afterlife_song);
            de_afterlife.AddSong(nothing_more);
            de_afterlife.AddSong(das_boot);
            de_afterlife.AddSong(hardcore_people);
            de_afterlife.AddSong(face_down_in_a_fountain);
            de_afterlife.AddSong(surround_me);
            de_afterlife.AddSong(too_deep);
            de_afterlife.AddSong(midnight);

            Console.WriteLine("CD data: " + afterlife.ToString());
            de_afterlife.PrintCollection();

        }
    }
}
