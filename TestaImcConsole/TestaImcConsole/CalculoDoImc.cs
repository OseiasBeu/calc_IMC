using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaImcConsole
{
    class CalculoDoImc
    {
        private double peso;
        private double altura;
        private double imc;
        private char sexo;
        private string classificacao;

        // construtores

        public CalculoDoImc()
        {
            peso = 0;
            altura = 0;
            imc = 0;
            sexo = 'M';
            classificacao = "";
        }

        // métodos das variaveis de instância encapsulados
        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getpeso()
        {
            return this.peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getAltura()
        {
            return this.altura;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public char getSexo()
        {
            return this.sexo;
        }
        public double getImc()
        {
            return this.imc;
        }
        public String getClassificacao()
        {
            return this.classificacao;
        }

        // escrever os métodos de negócio
        private void calcular_o_Imc()
        {
            this.imc = peso / (altura * altura);
        }
        private void fazer_a_Classificacao()
        {
            if (sexo == 'M' || sexo == 'm') // masculina
            {
                if (imc <= 20.7)
                {
                    this.classificacao = "Abaixo do peso.";
                }
                if (imc > 20.7 && imc <= 26.4)
                {
                    this.classificacao = "No peso normal.";
                }
                if (imc > 26.4 && imc <= 27.8)
                {
                    this.classificacao = "Marginalmente acima do peso.";
                }
                if (imc > 27.8 && imc <= 31.1)
                {
                    this.classificacao = "Acima do peso.";
                }
                if (imc > 31.1)
                {
                    this.classificacao = "Obeso.";
                }

            }
            else // feminina
            {
                if (imc <= 19.5)
                {
                    this.classificacao = "Abaixo do peso.";
                }
                if (imc > 19.5 && imc <= 25.8)
                {
                    this.classificacao = "No peso normal.";
                }
                if (imc > 25.8 && imc <= 27.3)
                {
                    this.classificacao = "Marginalmente acima do peso.";
                }
                if (imc > 27.3 && imc <= 32.3)
                {
                    this.classificacao = "Acima do peso.";
                }
                if (imc > 32.3)
                {
                    this.classificacao = "Obeso.";
                }
            }
        }

        public void calcular_Imc_Classificacao()
        {
            calcular_o_Imc();
            fazer_a_Classificacao();
        }

    }            
}
