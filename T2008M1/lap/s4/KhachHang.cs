using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace T2008M_AP.Lap.s4
{
    public class Khachang
    {
        private List<Hoadondien> khachhang;

        public Khachang()
        {
            khachhang = new List<Hoadondien>();
        }

        public Hoadondien this[int index]
        {
            get { return khachhang[index]; }
            set { khachhang[index] = value; }
        }
        public List<Hoadondien> KhachHang
        {
            get => KhachHang;
           
        }
        public void showAllBill()
        {
            foreach (var x in KhachHang)
            {
                if (x.GetType() == typeof(KhachVN) )
                { 
                    var a = (KhachVN) x;
                    Console.WriteLine(a.Id+"-"+a.Name+"-"+a.Date+"-"+a.showbill() +"-"+a.Doituong  );
                }
                else  if (x.GetType() == typeof(KhachNuocNgoai) )
                {
                    var a = (KhachNuocNgoai) x;
                    Console.WriteLine(a.Id+"-"+a.Name+"-"+a.Date+"-"+a.showbill()+"-"+a.Quoctich );

                }
            }   
        }

        public void loc()
        {
            var x = 0;
            do
            {
                Console.WriteLine("Bạn muốn chọn đối tượng nào? hãy ấn số");
                Console.WriteLine("1.Người Việt Nam");
                Console.WriteLine("2.Người nước ngoài");
                try
                {
                    x= Convert.ToInt32(Console.ReadLine()); 

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
                Console.WriteLine("Bạn nhập số:"+x);
            } while (x!=1&&x!=2);

            if (x==1)
            {
                Console.WriteLine("Nhập id của người muốn tìm:");
                
                tongsl(Convert.ToInt32(Console.ReadLine()), 1);
                return;
            } 
            Console.WriteLine("Nhập id của người muốn tìm:");
            tongsl(Convert.ToInt32(Console.ReadLine()), 2);
        }

        public void tongsl(int id,int chess)
        {
            int tong=0;
            foreach (var x in khachhang)
            {
                if (chess==1)
                {
                    if (x.GetType()==typeof(KhachVN)&&x.Id==id)
                    {
                        tong += x.Soluong;
                    }
                    
                }
                else
                {
                    if (x.GetType()==typeof(KhachNuocNgoai)&&x.Id==id)
                    {
                        tong += x.Soluong;
                    }
                }

               
            } 
            if (tong==0)
            {
                Console.WriteLine("Khong tim thay id ");
            }
            else
            { 
                Console.WriteLine("Tong so luong dien:" +tong);
            }
            
        }

        public void TbttNQ()
        {
            decimal tb = 0; var count=0;
            foreach (var x in KhachHang)
            {
                if (x.GetType() == typeof(KhachNuocNgoai))
                {
                    tb += x.showbill();
                    count++;
                }
            }
            Console.WriteLine("TBTTNQ la:" +tb/count);
        }

        public void showbillT1()
        {
            Console.WriteLine("ALl bill t1");
            foreach (var x in KhachHang)
            {
                if (x.Date =="01/2019")
                {
                    var a = x;
                    Console.WriteLine(a.Id+"-"+a.Name+"-"+a.Date+"-"+a.showbill() );
                }
            }
        }
    }
}