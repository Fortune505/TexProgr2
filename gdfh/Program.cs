using System;
using System.ComponentModel;
class B
{
    static void Main()
    {
        BP.Lol();
        BPL.Iga();
        BPLA.Elllo();
    }
}
// логика
class LogicBPLA
{
    public static double GetSKv(double a) => a * a;

    public static double GetSKr(double r)
    {
        const double pi = 3.14;
        return r * r * pi;
    }

    public static double GetCh(double a, int b) => a * b;

    public static string GetMena(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        return text.Replace("муха", "слон");
    }
}
// задача 1
class BP
{
   public static void Lol()
    {
        Console.WriteLine("Напишите сторону квадрата:");
        string dannoKvadro = Console.ReadLine();
        double a = Convert.ToDouble(dannoKvadro);
        Console.WriteLine("Напишите радиус круга:");
        string dannoKryg = Console.ReadLine();
        double r = Convert.ToDouble(dannoKryg);
        double SKv = LogicBPLA.GetSKv(a);
        double SKr = LogicBPLA.GetSKr(r);
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
// задача 2
class BPL
{
    public static void Iga()
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
                double result = LogicBPLA.GetCh(Chislo, i);
                Console.WriteLine($"{i} + {Chislo} = {result}");
            }
            Console.WriteLine("Хотите продолжыть таблицу умнажения: да или нет?");
            otvet = Console.ReadLine();

        } while (otvet == "да");

    }
}
// задача 3
class BPLA
{
    public static void Elllo()
    {
        Console.WriteLine("Введите текст для шифровки (замена муха на слона):");
        string text = Console.ReadLine();

        string shifr = LogicBPLA.GetMena(text);
        Console.WriteLine("Результат:");
        Console.WriteLine(shifr);
    }
}

