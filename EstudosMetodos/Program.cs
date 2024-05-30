using EstudosMetodos.Entities;
using System.Globalization;

namespace EstudosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t1, t2, teste;
            t1 = new Teste();
            t2 = new Teste();

            Console.Write("Qual seu time de coração: ");
            t1.Time = Console.ReadLine();

            Console.Write("Quantos Gols tem seu time: ");
            t1.GolsFeitos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Gols seu time sofreu: ");
            t1.GolsSofridos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.Write("Qual o Rival do seu time: ");
            t2.Time = Console.ReadLine();

            Console.Write("Quantos Gols tem o rival: ");
            t2.GolsFeitos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Gols sofreu o rival: ");
            t2.GolsSofridos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            double mediaT1 = t1.SaldoDeGols();
            double mediaT2 = t2.SaldoDeGols();

            Console.WriteLine("O Saldo de Gols do " + t1.Time + " foi de " + t1.SaldoDeGols());
            Console.WriteLine();
            Console.WriteLine("O Saldo de Gols do " + t2.Time + " foi de " + t2.SaldoDeGols());
            Console.WriteLine();
            Console.WriteLine("Palmeiras não tem mundial");   
        }
    }
}
