
using System;
using T2008M_AP.Lab.s1;

namespace T2008M_AP.Lab.s3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product b1 = new Product();
            b1.id = 1;
            b1.name = "sp1";
            b1.price = 1000000;
            b1.qty = 1;
            b1.image = "Anhdep.ipg";
            b1.description = "ABC";
            Product b2 = new Product();
            b2.id = 2;
            b2.name = "sp2";
            b2.price = 2000000;
            b2.qty = 2;
            b2.image = "Anhdep.ipg";
            b2.description = "ABC";
            
            Cart sp1 = new Cart();
            sp1.id = 1;
            sp1.customer = "Nguyen Van A";
            sp1.city = "HN";
            sp1.country = "Viet Nam";
            sp1.AddProduct(b1);
            sp1.AddProduct(b2);
            sp1.RemoveProduct(b2);
            
            Console.WriteLine("Danh sach cac sp:");
            foreach (var VARIABLE in sp1.productList)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("Tong tien:"+sp1.FinalGrandTotal());
           
        }
    }
}