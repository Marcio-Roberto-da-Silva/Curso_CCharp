using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
     public static void Executar()
        {
            Console.Write("Qual é seu Nome? ");
            string nome = Console.ReadLine ();

            Console.Write("Qual é sua Idade? ");
            int idade = int.Parse (Console.ReadLine());

            Console.Write("Qual é seu Salário");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            Console.WriteLine($"{nome} {idade} R${salario} ");
        }

    } 
}
