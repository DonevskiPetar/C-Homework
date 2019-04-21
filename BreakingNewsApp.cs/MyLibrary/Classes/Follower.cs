using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Classes
{
    public class Follower
    {
        public string Name { get; set; }
        public Follower (string name)
        {
            Name = name;
        }

        public void Subscribe(Medium medium)
        {
            medium.EventBreakingNews += new Medium.NewsDelegate(PrintNews);
            Console.WriteLine($"{this.Name} is subscribed");
        }

        public void PrintNews(object obj , NewsEventArgs BreakingNews)
        {
            Console.WriteLine($"{BreakingNews.Title} {BreakingNews.Content} {BreakingNews.Date}");
        }

    }
}
