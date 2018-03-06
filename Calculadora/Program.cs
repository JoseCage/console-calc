using System;
using Calculadora.Components;

/**
 * Programa criado para fins de estudo
 * Por: José Januário
 * @package: Calculadora
 *
*/

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao multi = new Multiplicacao();
            Console.WriteLine("Multiplicando");
            Console.WriteLine(multi.Multiplicar(50,50).ToString());
            Console.ReadLine();

            Soma somar = new Soma();
            Console.WriteLine("Somando");
            Console.WriteLine(somar.Somar(10,50).ToString());
            Console.ReadLine();

            Divisao dividir = new Divisao();
            Console.WriteLine("Divindo");
            Console.WriteLine(dividir.Dividir(100, 10));
            Console.ReadLine();

            Subtracao subtr = new Subtracao();
            Console.WriteLine("Subtraindo");
            Console.WriteLine(subtr.Subtrair(100, 20).ToString());
            Console.ReadLine();
        }
    }
}
