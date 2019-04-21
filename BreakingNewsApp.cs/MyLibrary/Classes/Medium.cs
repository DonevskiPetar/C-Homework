using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Classes
{
    public class Medium
    {
        public delegate void NewsDelegate(object obj , NewsEventArgs e);
        public event NewsDelegate EventBreakingNews;

        public void SendBreakingNews(string title , string content , DateTime date)
        {
            NewsEventArgs BreakingNews = new NewsEventArgs(title, content, date);
            if(EventBreakingNews == null)
            {
                Console.WriteLine("There is no subscribers");
                return;
            }
            EventBreakingNews(this, BreakingNews);
        }
    }

    public class NewsEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public NewsEventArgs(string title , string content , DateTime date)
        {
            Title = title;
            Content = content;
            Date = date;
        }
    }
    
}
