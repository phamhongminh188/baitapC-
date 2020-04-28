using System;

namespace chuong2_bt4
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tamgiac1 = new TamGiac();
            //tamgiac1.nhap();
            if (tamgiac1.IsTamGiac())
            {
                Console.WriteLine(" Diện tích và chu vi của tam giác bạn vừa nhập lần lượt là {0} và {1}",
                    tamgiac1.DienTich(), tamgiac1.ChuVi());

            }
            Console.ReadLine();

            TamGiac TamGiac2 = new TamGiac(2, 4, 3);
            Console.WriteLine("dien tích va chu vi tam giac thu 2 la {0} va {1}",
                TamGiac2.DienTich(), TamGiac2.ChuVi());
            Console.ReadLine();

        }
    }
}
