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
        LengthValores a;

        public string PegaValor(double valor)
        {
            a = new LengthValores();

            string valorPorExtenso = "";
            string valorSeparado = valor.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
            string[] stringDividida = valorSeparado.Split(',');
            string reais = stringDividida[0];
            string centavos = stringDividida[1];

            if (reais != "0")
            {
                valorPorExtenso = a.Converter(reais);
                return valorPorExtenso;
            }

            if(centavos != "0")
            {
                valorPorExtenso = a.Converter(reais);
            }

            return valorSeparado;
        }

        public string Unidades(char unidade)
        {
            switch (unidade)
            {
                case '0': return "";
                case '1': return "um";
                case '2': return "dois";
                case '3': return "três";
                case '4': return "quatro";
                case '5': return "cinco";
                case '6': return "seis";
                case '7': return "sete";
                case '8': return "oito";
                case '9': return "nove";
                default: return "";
            }
        }

        public string Dezenas(char dezena)
        {
            switch (dezena)
            {
                case '2': return "vinte";
                case '3': return "trinta";
                case '4': return "quarenta";
                case '5': return "cinquenta";
                case '6': return "sessenta";
                case '7': return "setenta";
                case '8': return "oitenta";
                case '9': return "noventa";
                default: return "";
            }
        }

        public string Centenas(char centena)
        {
            switch (centena)
            {
                case '1': return "cento";
                case '2': return "duzentos";
                case '3': return "trezentos";
                case '4': return "quatrocentos";
                case '5': return "quinhentos";
                case '6': return "seiscentos";
                case '7': return "setecentos";
                case '8': return "oitocentos";
                case '9': return "novecentos";
                default: return "";
            }
        }

        public string Cem(char centenas)
        {
            switch (centenas)
            {
                case '1': return "cem";
                default: return "";
            }
        }
    }
}

