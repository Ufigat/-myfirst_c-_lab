using System;

namespace L1
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("минимальная температура=" + (int)gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);
            Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");
            double x = Math.E;
            Console.WriteLine("E={0,20}", x);
            Console.WriteLine("E={0,10}", x);
            double y = 23234234.312423423;
            Console.WriteLine("E={0:#.###}", y);
            Console.WriteLine("E={0:.####}", y);
            Console.WriteLine("C Format:{0,14:C} \t{0:C1}", 12345.678);
            Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            Console.WriteLine("X Format:{0,14:X} ", 1234);
            Console.WriteLine("P Format:{0,14:P} ", 0.9);
            string s = Console.ReadLine();
            double с = double.Parse(s); //преобразование строки в число
            Console.WriteLine("F Format:{0:F3}", с);


            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);


            Console.Write("q= ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("w= ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={1}+{0}", q, w);

            Console.Write("a= ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}", z, v, j, z + v + j);


            Console.Write("a= ");
            float qq = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            float ww = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{1}={2:F1}", qq, ww, qq*ww);

            Console.Write("a= ");
            float qqq = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            float www = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2:F3}", qqq, www, qqq / www);







        }
    }
}
