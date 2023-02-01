using System;
namespace uppgift3
{
    class program
    {
        static void Main(string[] args)
        {
            int startavgiftin = 300;
            int kilometer = 1;
            int extra = 500;
            Console.WriteLine("Hur mång dagar du vill hyra bilen ");
            int dagar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mång kilometer du ska köra");
            int meter = Convert.ToInt32(Console.ReadLine());
            int Totala = startavgiftin + (kilometer * meter) + (dagar - 1) * extra;
            Console.WriteLine("Den totala kostnaden för att hyra bilen är = " + Totala + " Kr");
        }
    }
}
