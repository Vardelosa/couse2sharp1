using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class CopywriterListHandlerEventArgs : System.EventArgs
    {
        public string ColName { get; set; }
        public string ColChanges { get; set; }
        public Copywriter Link { get; set; }
        CopywriterListHandlerEventArgs()
        {

        }
        CopywriterListHandlerEventArgs(string cn, string cc, Copywriter link)
        {
            ColName = cn;
            ColChanges = cc;
            Link = link;

        }
        public override string ToString()
        {
            string s = ColName +"\n" + ColChanges+ "\n" + Link.ToShortString();
            return s;
        }
    }
}
