using Collections_Homework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Homework.Entities
{
    public class Person
    {
        public string firstName;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; } 
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre genre)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FavouriteMusicType = genre;
        }
        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
