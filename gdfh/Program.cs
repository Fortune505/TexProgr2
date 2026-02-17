using System;
class BP
{
   static void Lor()
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

class BPL
{
    static void Iga()
    {

        string dannoChislo;
        double Chislo;
        string otvet;
        do
        {

            do
            {
                Console.WriteLine("Введите число:");
                dannoChislo = Console.ReadLine();
                Chislo = Convert.ToDouble(dannoChislo);
            } while (1 > Chislo || Chislo > 9);

            Console.WriteLine("Вывод таблицы:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i} + {Chislo} = {i * Chislo}");
            }
            Console.WriteLine("Хотите продолжыть таблицу умнажения: да или нет?");
            otvet = Console.ReadLine();

        } while (otvet == "да");

    }
}
