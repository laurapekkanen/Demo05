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
            //create cd
            CD afterlife = new CD
            { Name = "Afterlife", Artist = "Disco Ensemble", Price = 19.99 };

            //create songs
            Song reality = new Song
            { Number = 1, Title = "Reality", Length = "4:13" };
            Song fight_forever = new Song
            { Number = 2, Title = "Fight Forever", Length = "3:59" };
            Song disppear = new Song
            { Number = 3, Title = "Disappear", Length = "3:41" };
            Song afterlife_song = new Song
            { Number = 4, Title = "Afterlife", Length = "4:34" };
            Song nothing_more = new Song
            { Number = 5, Title = "Nothing More", Length = "3:40" };
            Song das_boot = new Song
            { Number = 6, Title = "Das Boot", Length = "3:44" };
            Song hardcore_people = new Song
            { Number = 7, Title = "Hardcore People", Length = "3:26" };
            Song face_down_in_a_fountain = new Song
            { Number = 8, Title = "Face Down in a Fountain", Length = "2:51" };
            Song surround_me = new Song
            { Number = 9, Title = "Surround Me", Length = "4:09" };
            Song too_deep = new Song
            { Number = 10, Title = "Too Deep", Length = "3:56" };
            Song midnight = new Song
            { Number = 11, Title = "Midnight", Length = "4:00" };

            //add cd to collection
            CDs afterlife_album = new CDs();
            afterlife_album.AddCd(afterlife);

            //add songs to collection
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
            
            //print data
            afterlife_album.PrintCollection();
            de_afterlife.PrintCollection();

            //let's make another cd
            CD i_see_you = new CD
            { Name = "I See You", Artist = "The XX", Price = 21.99 };

            //create some songs
            Song dangerous = new Song
            { Number = 1, Title = "Dangerous", Length = "4:10" };
            Song say_something_loving = new Song
            { Number = 2, Title = "Say Something Loving", Length = "3:21" };
            Song lips = new Song
            { Number = 3, Title = "Lips", Length = "3:21" };
            Song a_violent_noise = new Song
            { Number = 4, Title = "A Violent Noise", Length = "3:47" };
            Song performance = new Song
            { Number = 5, Title = "Performance", Length = "4:06" };
            Song replica = new Song
            { Number = 6, Title = "Replica", Length = "4:09" };
            Song brave_for_you = new Song
            { Number = 7, Title = "Brave For You", Length = "4:13" };
            Song on_hold = new Song
            { Number = 8, Title = "On Hold", Length = "3:44" };
            Song i_dare_you = new Song
            { Number = 9, Title = "I Dare You", Length = "3:53" };
            Song test_me = new Song
            { Number = 10, Title = "Test Me", Length = "3:56" };

            //cd to collection
            CDs i_see_you_album = new CDs();
            i_see_you_album.AddCd(i_see_you);

            //songs to collection
            Songs thexx_iseeyou = new Songs();
            thexx_iseeyou.AddSong(dangerous);
            thexx_iseeyou.AddSong(say_something_loving);
            thexx_iseeyou.AddSong(lips);
            thexx_iseeyou.AddSong(a_violent_noise);
            thexx_iseeyou.AddSong(performance);
            thexx_iseeyou.AddSong(replica);
            thexx_iseeyou.AddSong(brave_for_you);
            thexx_iseeyou.AddSong(on_hold);
            thexx_iseeyou.AddSong(i_dare_you);
            thexx_iseeyou.AddSong(test_me);

            //print stuff
            i_see_you_album.PrintCollection();
            thexx_iseeyou.PrintCollection();
        }
    }
}
