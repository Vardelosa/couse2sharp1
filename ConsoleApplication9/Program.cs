using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            CopywriterCollection collection = new CopywriterCollection();
            Person[] persons = new Person[3];
            Copywriter[] copyrat = new Copywriter[3];
            persons[0] = new Person("Vladimir", "Ahakov", new DateTime(2000, 11, 13));
            persons[1] = new Person("Artemiy", "Begasov", new DateTime(1997, 03, 05));
            persons[2] = new Person("John", "Cook", new DateTime(1999, 09, 27));
            copyrat[0] = new Copywriter(persons[0], "King", (Level)1, 4);
            copyrat[1] = new Copywriter(persons[1], "Rognak", 0, 3);
            copyrat[2] = new Copywriter(persons[2], "Kilimonjaru", 0, 2);
            copyrat[0].AddArticles(new Article[3] { new Article("Horray", 26, new DateTime(2000, 6, 11)), new Article("Gagaga", 45, new DateTime(2000, 7, 13)), new Article("Mimiha", 55, new DateTime(1999, 12, 25)) });
            copyrat[1].AddArticles(new Article[3] { new Article("Koralu", 24, new DateTime(2000, 7, 12)), new Article("Kikia", 37, new DateTime(2000, 7, 13)), new Article("Pomopa", 19, new DateTime(1999, 12, 25)) });
            copyrat[2].AddArticles(new Article[3] { new Article("Summo", 21, new DateTime(1999, 8, 14)), new Article("Ginger", 21, new DateTime(2000, 7, 13)), new Article("Kiraju", 10, new DateTime(1999, 12, 25)) });
            collection.AddCopywriters(copyrat[0], copyrat[1], copyrat[2]);
            Console.WriteLine("Sort by surname: \n");
            collection.SortBySurname();          
            Console.WriteLine("\n {0}", collection.ToShortString());
            Console.WriteLine("Sort by date: \n");
            collection.SortByData();
            Console.WriteLine("\n {0}", collection.ToShortString());
            Console.WriteLine("Sort by middle: \n");
            collection.SortByMiddle();
            Console.WriteLine("\n {0} \n", collection.ToShortString());

            int n = 10000;
            TestCollections testcollection = new TestCollections(n);
            Copywriter searchcopy = TestCollections.GenerateCopywriter(1);
            Console.WriteLine("Searching 1 element:\n");
            Console.WriteLine("Person List: " + testcollection.TimePers(searchcopy));
            Console.WriteLine("Str List: " + testcollection.TimeStr(searchcopy));
            Console.WriteLine("Person Dictionary Key: " + testcollection.TimeCopyDicKey(searchcopy));
            Console.WriteLine("Str Dictionary Key: " + testcollection.TimeStrDicKey(searchcopy));
            Console.WriteLine("Person Dictionary Value: " + testcollection.TimeCopyDic(searchcopy));
            Console.WriteLine("Str Dictionary Value: " + testcollection.TimeStrDic(searchcopy) + "\n");

            Copywriter searchcopy1 = TestCollections.GenerateCopywriter(n/2);
            Console.WriteLine("Searching middle element:\n");
            Console.WriteLine("Person List: " + testcollection.TimePers(searchcopy1));
            Console.WriteLine("Str List: " + testcollection.TimeStr(searchcopy1));
            Console.WriteLine("Person Dictionary Key: " + testcollection.TimeCopyDicKey(searchcopy1));
            Console.WriteLine("Str Dictionary Key: " + testcollection.TimeStrDicKey(searchcopy1));
            Console.WriteLine("Person Dictionary: " + testcollection.TimeCopyDic(searchcopy1));
            Console.WriteLine("Str Dictionary: " + testcollection.TimeStrDic(searchcopy1) + "\n");

            Copywriter searchcopy2 = TestCollections.GenerateCopywriter(n);
            Console.WriteLine("Searching last element:\n");
            Console.WriteLine("Person List: " + testcollection.TimePers(searchcopy2));
            Console.WriteLine("Str List: " + testcollection.TimeStr(searchcopy2));
            Console.WriteLine("Person Dictionary Key: " + testcollection.TimeCopyDicKey(searchcopy2));
            Console.WriteLine("Str Dictionary Key: " + testcollection.TimeStrDicKey(searchcopy2));
            Console.WriteLine("Person Dictionary: " + testcollection.TimeCopyDic(searchcopy2));
            Console.WriteLine("Str Dictionary: " + testcollection.TimeStrDic(searchcopy2)+"\n");

            Copywriter searchcopy3 = TestCollections.GenerateCopywriter(n+2);
            Console.WriteLine("Checking for error...\n");
            Console.WriteLine("Person List: " + testcollection.TimePers(searchcopy3));
            Console.WriteLine("Str List: " + testcollection.TimeStr(searchcopy3));
            Console.WriteLine("Person Dictionary Key: " + testcollection.TimeCopyDicKey(searchcopy3));
            Console.WriteLine("Str Dictionary Key: " + testcollection.TimeStrDicKey(searchcopy3));
            Console.WriteLine("Person Dictionary: " + testcollection.TimeCopyDic(searchcopy3));
            Console.WriteLine("Str Dictionary: " + testcollection.TimeStrDic(searchcopy3));
            Console.ReadKey();
        }
    }
}
