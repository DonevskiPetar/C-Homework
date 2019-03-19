using Collections_Homework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Homework.Entities
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, int length, Genre Genre)
        {
            this.Title = title;
            this.Length = length;
            this.Genre = Genre;
        }
    }
}
