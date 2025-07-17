using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Cpf
    {
        public bool ValidarCpf(string cpf)
        {
            string[] caracteresDoCpf = new string[14];
            for (int i = 0; i < cpf.Length; i++) 
            {
                caracteresDoCpf[i] = cpf[i].ToString();
            }

            // CALCULO DO 1º DIGITO VERIFICADOR
            int digitoVerificadorUm = ((10 * int.Parse(caracteresDoCpf[0])) + (9 * int.Parse(caracteresDoCpf[1])) + (8 * int.Parse(caracteresDoCpf[2])) +
                                       (7 * int.Parse(caracteresDoCpf[4])) + (6 * int.Parse(caracteresDoCpf[5])) + (5 * int.Parse(caracteresDoCpf[6])) + 
                                       (4 * int.Parse(caracteresDoCpf[8])) + (3 * int.Parse(caracteresDoCpf[9])) + (2 * int.Parse(caracteresDoCpf[10])));

            digitoVerificadorUm = digitoVerificadorUm % 11;
            if( digitoVerificadorUm == 0 || digitoVerificadorUm == 1)
            {
                digitoVerificadorUm = 0;
            }
            else
            {
                digitoVerificadorUm = 11 - digitoVerificadorUm;
            }

            int digitoVerificadorDois = (((11 * int.Parse(caracteresDoCpf[0])) + (10 * int.Parse(caracteresDoCpf[1])) + (9 * int.Parse(caracteresDoCpf[2])) +
                                         (8 * int.Parse(caracteresDoCpf[4])) + (7 * int.Parse(caracteresDoCpf[5])) + (6 * int.Parse(caracteresDoCpf[6])) +
                                         (5 * int.Parse(caracteresDoCpf[8])) + (4 * int.Parse(caracteresDoCpf[9])) + (3 * int.Parse(caracteresDoCpf[10])) +
                                         (2 * digitoVerificadorUm)));
            // CALCULO DO 2º DIGITO VERIFICADOR
            digitoVerificadorDois = digitoVerificadorDois % 11;
            if(digitoVerificadorDois == 0 || digitoVerificadorDois == 1)
            {
                digitoVerificadorDois = 0;
            }
            else
            {
                digitoVerificadorDois = 11 - digitoVerificadorDois;
            }

            if (int.Parse(caracteresDoCpf[12]) == digitoVerificadorUm && int.Parse(caracteresDoCpf[13]) == digitoVerificadorDois)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
