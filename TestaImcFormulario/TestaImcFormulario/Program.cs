using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaImcFormulario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularImc imcLucas = new CalcularImc();

            // entrada de dados
            Console.Write("Entre o Peso em Kg...: ");
            imcLucas.setPeso(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Entre a altura em mts...: ");
            imcLucas.setAltura(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Entre o sexo ...: ");
            imcLucas.setSexo(Convert.ToChar(Console.ReadLine()));



            // processamento
            imcLucas.calcular_Imc_Classificacao();

            // dsida de dados
            Console.WriteLine("IMC = " + imcLucas.getImc());
            Console.WriteLine("Classificação =  " + imcLucas.getClassificacao());

            Console.Write("Tecle <ENTER> para continuar....... ");
            Console.ReadKey();
        }
    }
}
