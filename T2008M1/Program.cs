using System;

namespace T2008M1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello word!");
            Console.WriteLine("Nhap 1 chuoi:");
            string s = Console.ReadLine();
            Console.WriteLine("s= "+s);
            Console.WriteLine("Nhap vao 1 so nguyen:");

            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine())
            }
            catch (Exception e)
            {
                n = 0;
            }
            Console.WriteLine("so vua nhap:"+n);
            if (Check  Prime(n)) ;
            {
                
            }
        }
    }
}