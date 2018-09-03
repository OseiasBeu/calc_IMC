using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaImcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDoImc humanoide = new CalculoDoImc();

            // entrada de dados
            Console.Write("Entre o Peso em Kg...: ");
            humanoide.setPeso(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Entre a altura em mts...: ");
            humanoide.setAltura(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Entre o sexo ...: ");
            humanoide.setSexo(Convert.ToChar(Console.ReadLine()));

           

            // processamento
            humanoide.calcular_Imc_Classificacao();

            // dsida de dados
            Console.WriteLine("IMC = "              + humanoide.getImc());
            Console.WriteLine("Classificação =  "   + humanoide.getClassificacao());

            Console.Write("Tecle <ENTER> para continuar....... ");
            Console.ReadKey();
        }
    }
}
