using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Songs
    {
        private List<Song> songs;

        public Songs()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PrintCollection()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

        }
    }
}
