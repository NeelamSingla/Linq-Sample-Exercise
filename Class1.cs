using System;
using System.Linq;
using System.Collections.Generic;
namespace practice1
{
    public class Class1
    {

        public static void Main()
        {
            Linq l = new Linq();
            l.Linq1();
            l.Linq5();

            DupString stringdemo = new DupString();
            stringdemo.duplicateString();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 2, 3 };
            var arr1 = from s in arr
                       group s by s into g
                       select g;


            Console.ReadKey();

            string str;

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                       group x by x into y
                       select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
            Console.ReadKey();

            getPersonList();
        }


        static void getPersonList()
        {
            List<Person> people = new List<Person>()
            { new Person(30,"Neelam",new DateTime(1985,07,01)),
              new Person(35, "Shweta",new DateTime(1987,07,01)),
              new Person(21, "savi",new DateTime(1989,07,01)),
              new Person(29, "Aksi",new DateTime(2000,07,01)),
            };
            var sortdedlist=people.OrderByDescending(p => p.Getname);


            foreach (Person p in sortdedlist)
            {
                Console.WriteLine("name {0}, Age {1}", p.Getname, p.GetAge);
                Console.ReadLine();
            }

            var Above25 = from item in people
                where item.GetAge >= 25
                select item;
            var Nnamed = from x in people
                         where x.GetAge > 26 && x.Getname.StartsWith("N")
                         select x;
            foreach (Person p in Above25)
            {
                Console.WriteLine(" Person Above 25 name {0}, Age {1}", p.Getname, p.GetAge);
                Console.ReadLine();
            }
            foreach (Person p in Nnamed)
            {
                Console.WriteLine("Person starting name with N name {0}, Age {1}", p.Getname, p.GetAge);
                Console.ReadLine();
            }

           Console.ReadKey();




    }
    public class Person
    {
             private int age;
            private string name;
            private DateTime dob;

        public Person(int age, string name, DateTime dob)
        {
            this.age = age;
            this.name = name;
            this.dob = dob;
        }

        public int GetAge
        {
                get
                { return age; }
                set {; }

            }
        public string Getname
        {
                get
                { return name; }
                set {; }
                

        }





            public void getWordCount()
        {
            string text = @"Historically, the world of data and the world of objects" +
           @" have not been well integrated. Programmers work in C# or Visual Basic" +
           @" and also in SQL or XQuery. On the one side are concepts such as classes," +
           @" objects, fields, inheritance, and .NET Framework APIs. On the other side" +
           @" are tables, columns, rows, nodes, and separate languages for dealing with" +
           @" them. Data types often require translation between the two worlds; there are" +
           @" different standard functions. Because the object world has no notion of query, a" +
           @" query can only be represented as a string without compile-time type checking or" +
           @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
           @" objects in memory is often tedious and error-prone.";

            string searchTerm = "data";

            //Convert the string into an array of words  
            string[] source = text.Split(new Char[] { ',', '.', '|', '+' }, StringSplitOptions.RemoveEmptyEntries);

            // Create the query.  Use ToLowerInvariant to match "data" and "Data"   
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            // Count the matches, which executes the query.  
            int wordCount = matchQuery.Count();
            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

            // Keep console window open in debug mode  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }




}
}
