using Collections_Homework.Entities;
using Collections_Homework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types of lists in C#
            //Dictionary (Unordered - can’t use indexes)
            //List
            //Queue (Unordered - can’t use indexes)
            //Stack (Unordered - can’t use indexes)

            //Dictionary is a generic function that takes two types and two values. One is called 
            //a key and the other a value. This makes key-value pairs which are amazing for storing and labeling data.

            //List is a list is a generic collection that holds items of a certain type. It is a multi purpose collection 
            //that can be used in different scenarios without the constraints that arrays have. 

            //Queue is a collection which can store and give back items of a certain type.The items in this collection 
            //always go in the order -FIFO meaning First In First Out - the first item that we put in will be the first we get.

            //Stack is a collection which can store and give back items of a certain type and also works in a particular 
            //order.LIFO is the order meaning Last In First Out.

            //For Stack and Queue
            //Enqueue(queue) and Push(stack) add items to the collection
            //Dequeue(queue) and Pop(stack) remove the item that is next
            //Peek - Returns the item that is next

            //For Dictionary and List
            //Add - adds item in the collection
            //Remove - removes item in the collection
            //Count - returns the number of elements


            List<int> nums = new List<int>();
            nums.Add(5);
            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums.Count); //prints 1
            List<string> names = new List<string>();
            names.Add("Petar");
            names.Add("Rebeka");
            //Console.WriteLine(names[0]); //access list


            Dictionary<int, string> phBook = new Dictionary<int, string>();
            phBook.Add(1, "petar");
            phBook.Add(2, "rebeka");
            phBook.Add(3, "ace");
            phBook.Add(50, "ACC");
            //Console.WriteLine(phBook[1].ToString());  // print petar
            //Console.WriteLine(phBook[50]); // print ACC
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("majmun", "banana");
            words.Add("kuce", "koska");
            words.Add("macka", "glusec");
            //Console.WriteLine(words["majmun"]); // print banana



            ///////////////////Linq methods

            //Different types of linq methods
            //We use linq methods to manipulate with our collections in different ways. We can chain different methods 
            //to make a more complex logic.The thing to always remember is that all linq methods that return a collection, 
            //return the collection as IEnumerable type.We don’t have much control with this sort of type so we always 
            //try and convert the result in to something more workable like List

            //Where()
            //This method filters out items by a rule that we write.All items are returned in a collection even if 
            //thereis only one

            //Select()
            //Selects only a certain thing from the main entity(Ex.property of an object) and returns a new collection 
            //of only those values

            //First()/Last()
            //Returns the first or last item from a collection.They also throw an error if there are none. To avoid this
            //there are FirstOrDefault and SingleOrDefault methods that do not throw an error

            //ToList()
            //Creates a collection that is not a List in to a List type collection






            #region Exercise No.1
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //phoneBook.Add("petar", "200300");
            //phoneBook.Add("dario", "500600");
            //phoneBook.Add("martin", "400900");
            //phoneBook.Add("goran", "800950");
            //phoneBook.Add("viktor", "650450");
            //phoneBook.Add("dejan", "320450");

            //Console.WriteLine("Enter a name");
            //string name = Console.ReadLine();
            //Console.Write(checkNumber(name , phoneBook));
            //Console.ReadLine();
            #endregion Exercise No.1

            #region Exercise No.2
            List<Person> FansArray = new List<Person>();

            //fans
            Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);


            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
            Song song10 = new Song("Fight the Power", 321, Genre.Techno);
            Song song11 = new Song("The Message", 363, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
            Song song13 = new Song("No Fear", 182, Genre.Techno);
            Song song14 = new Song("Hereditary", 340, Genre.Techno);
            Song song15 = new Song("Bounce Back", 226, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
            Song song23 = new Song("Planet E", 420, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 242, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 359, Genre.Techno);
            Song song28 = new Song("Phalanx", 307, Genre.Techno);
            Song song29 = new Song("Vision", 693, Genre.Techno);
            Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

            List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                  song8, song9, song10, song11, song12, song13, song14,song15, song16, song17, song18,
                  song19, song20,song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };


            #endregion Exercise No.2

            #region Exercises No.3

            //Select the person Jerry and add all the songs which start with the letter B
            //Select the person Maria and add all the songs with length longer than 6 mins
            //Select the person Jane and add all the songs that are of genre Rock
            //Select the person Stefan and add all songs shorter than 3 mins and of genre Hip - Hop
            //Select all persons from the persons array that have 4 or more songs

            Jerry.FavoriteSongs = Songs.Where(song => song.Title.StartsWith("B")).ToList();
            Console.WriteLine("Jerry Favourite songs");
            Jerry.GetFavSongs(); 


            Maria.FavoriteSongs = Songs.Where(song => song.Length > 360).ToList();
            Console.WriteLine("Maria Favourite songs");
            Maria.GetFavSongs();


            Jane.FavoriteSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();
            Console.WriteLine("Jane Favourite songs");
            

            Stefan.FavoriteSongs = Songs.Where(song => song.Length < 180 && song.Genre == Genre.Hip_Hop).ToList();
            Console.WriteLine("Stefan Favourite songs");


            foreach(var person in FansArray)
            {
                if(person.FavoriteSongs.Count >= 4)
                {
                    Console.WriteLine(person.firstName);
                }
            }

            Console.ReadLine();

            #endregion Exercises No.3




        }
        #region Exercise No.1
        //public static string checkNumber(string name , Dictionary <string , string> phoneBook)
        //{
        //    if (phoneBook.ContainsKey(name) == true)
        //    {
        //        return $"{name}`s number is {phoneBook[name]}";
        //    }
        //    return "Name not found";
        //}
        #endregion Exercise No.1
    }
}
