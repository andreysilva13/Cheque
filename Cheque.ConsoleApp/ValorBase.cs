using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{   
    public class ValorBase
    {
        ConverterValores a;

        public string PegaValor(double valor)
        {
            a = new ConverterValores();

            string valorPorExtenso = "";
            string valorSeparado = valor.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
            string[] stringDividida = valorSeparado.Split(',');
            string reais = stringDividida[0];
            string centavos = stringDividida[1];

            if(reais != "0")
            {
                valorPorExtenso = a.Converter(reais);
                return valorPorExtenso;
            }

            return valorSeparado;
        }
    }
}
