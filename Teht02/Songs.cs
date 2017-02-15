﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Songs
    {
        //collection
        private List<Song> songs;

        //default constructor
        public Songs()
        {
            songs = new List<Song>();
        }

        //add song to list
        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        //print list
        public void PrintCollection()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }

        }
    }
}
