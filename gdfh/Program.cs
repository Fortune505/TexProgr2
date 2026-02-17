using System;
class BP
{
   static void Main()
    {
        Console.WriteLine("Напишите сторону квадрата:");
        string dannoKvadro = Console.ReadLine();
        double a = Convert.ToDouble(dannoKvadro);
        Console.WriteLine("Напишите радиус круга:");
        string dannoKryg = Console.ReadLine();
        double r = Convert.ToDouble(dannoKryg);
        const double pi = 3.14;
        double SKv = a * a;
        double SKr = r * r * pi;
        if (SKv > SKr)
        {
            Console.WriteLine("Площадь квадрата больше:");
            Console.WriteLine(SKv);
        }
        else {
            Console.WriteLine("Площадь круга больше:");
            Console.WriteLine(SKr);
        }


    }
}
