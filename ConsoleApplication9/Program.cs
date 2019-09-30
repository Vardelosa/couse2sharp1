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
            CopywriterCollection c1 = new CopywriterCollection();
            CopywriterCollection c2 = new CopywriterCollection();
            c1.ColName = "Collection 1";
            c2.ColName = "Сollection 2";
            Journal j1 = new Journal();
            Journal j2 = new Journal();
            c1.CopywritersCountChanged += j1.CountChanger;
            c1.CopywriterReferenceChanged += j1.RefChanger;
            c1.CopywriterReferenceChanged += j2.CountChanger;
            c2.CopywriterReferenceChanged += j2.RefChanger;
            c1.AddDefaults();
            c2.AddDefaults();
            c1.Remove(0);
            c2.Remove(1);
            c1[1] = c2[0];
            c2[1] = c1[0];
            Console.WriteLine(j1.ToString());
            Console.WriteLine(j2.ToString());
            Console.ReadKey();
        }
    }
}
