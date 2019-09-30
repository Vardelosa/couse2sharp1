using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Journal
    {
        public List<JournalEntry> JournalList= new List<JournalEntry>();
        public void CountChanger(object source, CopywriterListHandlerEventArgs args)
        {
            JournalList.Add(new JournalEntry(args.ColName, args.ColChanges, args.Link.ToShortString()));
        }
        public void RefChanger(object source, CopywriterListHandlerEventArgs args)
        {
            JournalList.Add(new JournalEntry(args.ColName, args.ColChanges, args.Link.ToShortString()));
        }
        public override string ToString()
        {
            string s = "";
            foreach(var c in JournalList)
            {
                s += c.ToString();
            }
            return s;
        }
    }
}
