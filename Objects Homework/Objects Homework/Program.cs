using System;

namespace ObjectsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Human
            //Human petar = new Human("Petar" , "Donevski" , 31);
            //Console.WriteLine(petar.GetPersonStats());
            //Console.WriteLine(petar.firstName);
            //Console.WriteLine(petar.lastName);
            //Console.ReadLine();

            //Create Human from user input
            //Console.WriteLine("Enter first name for the new Human:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter last name");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Enter age");
            //int age = int.Parse(Console.ReadLine());
            //Human newHuman = new Human(firstName , lastName , age);
            //Console.WriteLine(newHuman.GetPersonStats());
            //Console.ReadLine();
            #endregion Human

            #region Dog
            //Console.WriteLine("Enter a name for the dog:");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter a race:");
            //string Race = Console.ReadLine();
            //Console.WriteLine("Enter color");
            //string Color = Console.ReadLine();
            //Dog doggy = new Dog(Name, Race, Color);
            //Console.WriteLine(doggy.Eat());
            //Console.ReadLine();
            #endregion Dog

            #region Student

            Student petar = new Student("Petar", "Donevski", "G2");
            Student dario = new Student("Dario", "Kostov", "G2");
            Student viktor = new Student("Viktor", "Mijalcev", "G2");
            Student dragana = new Student("Dragana", "Siskovska", "G2");
            Student goran = new Student("Goran", "Todorovski", "G2");

            Student[] studentsArray = new Student[5];
            studentsArray[0] = petar;
            studentsArray[1] = dario;
            studentsArray[2] = viktor;
            studentsArray[3] = dragana;
            studentsArray[4] = goran;

            Console.WriteLine("Enter students name to check for info:");
            string input = Console.ReadLine();

            var found = true;

            for (int i = 0; i < studentsArray.Length; i++)
            {
                if (input.ToLower() == studentsArray[i].Name.ToLower())
                {
                    found = false;
                    Console.WriteLine(studentsArray[i].Name + " " + studentsArray[i].Academy + " " + studentsArray[i].Group);
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("There is no such student");
            }
            Console.ReadLine();
        }
    }
    #endregion Student
    #region Human
    //
    //public class Human
    //{
    //    public Human(string firstName, string lastName, int age)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //        this.age = age;
    //    }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public int age { get; set; }

    //    public string GetPersonStats()
    //    {
    //        return $"My name is {this.firstName} , my last name is {this.lastName} and im {this.age} years old";
    //    }
    //}
    #endregion Human

    #region Dog

    public class Dog
        {
            public Dog(string Name, string Race, string Color)
            {
                this.Name = Name;
                this.Race = Race;
                this.Color = Color;
            }
            public string Name { get; set; }
            public string Race { get; set; }
            public string Color { get; set; }

            public string Eat()
            {
                return $"The dog {Name} is now eating";
            }
            public string Play()
            {
                return $"The dog {Name} is now playing";
            }
            public string ChaseTail()
            {
                return $"The dog {Name} is now chasing its tail";
            }
        }

    #endregion Dog

    #region Student
    public class Student
    {
        public Student(string Name, string Academy, string Group)
        {
            this.Name = Name;
            this.Academy = Academy;
            this.Group = Group;
        }
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
    }
    #endregion Student

}