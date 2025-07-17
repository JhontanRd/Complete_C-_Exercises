using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGeradorDeRa.BE
{
    public class Aleatorio
    {
        public Aleatorio(int quantidadeDeNumeros)
        {
            _quantidadeDeNumeros = quantidadeDeNumeros;
        }

        public Aleatorio(int quantidadeDeLetras, int quantidadeDeNumeros) : this(quantidadeDeNumeros)
        {
            _quantidadeDeNumeros = quantidadeDeNumeros;
            _quantidadeDeLetras = quantidadeDeLetras;
        }

        private int _quantidadeDeLetras;
        private int _quantidadeDeNumeros;

        public string GerarRASemLetras()
        {
            Random numAleatorio = new Random();
            string codigoRa = null;

            for (int i = 0; i < _quantidadeDeNumeros; i++) 
            {
                int numInteiro = numAleatorio.Next(0, 10);
                string novoDigito = numInteiro.ToString();
                codigoRa = codigoRa + novoDigito;
            }
            return codigoRa;
        }

        public string GerarLetras()
        {
            string posicao = string.Empty;
            int[] valoresAsciiAlfabeto = { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
            Random numAleatorio = new Random();

            for (int i = 0; i < _quantidadeDeLetras; i++)
            {
                int numInteiro = numAleatorio.Next(0, valoresAsciiAlfabeto.Length);
                char novaLetra = Convert.ToChar(valoresAsciiAlfabeto[numInteiro]);
                posicao += novaLetra;
            }
            return posicao;
        }

        public string GerarRAComLetras()
        {
            string letras = this.GerarLetras();
            string digitos = this.GerarRASemLetras();
            return letras + '-' + digitos;
        }
    }
}
