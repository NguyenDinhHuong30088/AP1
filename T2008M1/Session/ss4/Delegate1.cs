using System;

namespace T2008M_AP.Session.s4
{
    public class Delegate1
    {
        public Delegate1()
        {
            Delegate.publicDelegate += ShowName;
        }

        public static void ShowName(string msg)
        {
            Console.WriteLine("Name: "+msg);
        }
    }
}