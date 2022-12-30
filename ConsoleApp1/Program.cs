

using System;

namespace fahrenayt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İSMİNİZİ GİRİNİZ..");

        string girilenisim = Console.ReadLine();

        for (int baslangic = 0; baslangic < 10; baslangic++)
        {
            Console.WriteLine(girilenisim);
        }
        Console.ReadKey();

    }
}
