using System;

namespace T2008M_AP.Lap.s4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Khachang list = new Khachang();
            KhachVN v1 = new KhachVN(1, "BCT","01/2019", "28/01/2019", 63, "Sinh hoạt");
            KhachVN v12 = new KhachVN(1, "BCT","02/2019","28/02/2019", 78, "Sinh hoạt");
            KhachVN v2 = new KhachVN(2, "Cty", "01/2019","28/01/2019", 500, "Sản xuất");
            KhachVN v22 = new KhachVN(2, "Cty","02/2019", "28/02/2019", 600, "Sản xuất");
            KhachVN v3 = new KhachVN(3, "TTT","01/2019", "28/01/2019", 78, "Kinh doanh");
            KhachVN v32 = new KhachVN(3, "TTT","02/2019", "28/02/2019", 79, "Kinh doanh");
            KhachNuocNgoai n1 = new KhachNuocNgoai(1, "John","01/2019", "28/01/2019", 90, "Anh");
            KhachNuocNgoai n12 = new KhachNuocNgoai(1, "John", "02/2019","28/02/2019", 110, "Anh");
            KhachNuocNgoai n2 = new KhachNuocNgoai(2, "Lucher","01/2019", "28/01/2019", 83, "Mỹ");
            KhachNuocNgoai n22 = new KhachNuocNgoai(2, "Lucher","02/2019", "28/02/2019", 93, "Mỹ");
            list.KhachHang.Add(v1);
            list.KhachHang.Add(v12);
            list.KhachHang.Add(v2);
            list.KhachHang.Add(v22);
            list.KhachHang.Add(v3);
            list.KhachHang.Add(v32);
            list.KhachHang.Add(n1);
            list.KhachHang.Add(n12);
            list.KhachHang.Add(n2);
            list.KhachHang.Add(n22);
            list.showAllBill();
            list.loc();
            list.TbttNQ();
            list.showbillT1();
            



        }
    }

    
}