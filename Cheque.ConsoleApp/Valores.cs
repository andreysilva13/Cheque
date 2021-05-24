using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{
    public abstract class Valores : ValorBase
    {
        public string CentenaDezenaUnidade(char centena, char dezena, char unidade)
        {
            if (centena == '1' && dezena == '0' && unidade == '0')
            {
                return Cem(centena);
            }
            else if (dezena == '0' && unidade == '0')
            {
                return Centenas(centena);
            }
            else if (centena == '0')
            {
                return "e " + DezenaUnidade(unidade, dezena);
            }
            else if (dezena == '0' && unidade != '0')
            {
                return Centenas(centena) + " e " + Unidades(unidade);
            }
            else
            {
                return Centenas(centena) + " e " + DezenaUnidade(unidade, dezena);
            }

        }
        public string DezenaUnidade(char dezena, char unidade)
        {
            if (dezena == '0')
            {
                return Unidades(unidade);
            }

            else if (dezena == '1')
            {
                switch (unidade)
                {
                    case '0': return "dez";
                    case '1': return "onze";
                    case '2': return "doze";
                    case '3': return "treze";
                    case '4': return "quatorze";
                    case '5': return "quinze";
                    case '6': return "dezesseis";
                    case '7': return "dezesete";
                    case '8': return "dezoito";
                    case '9': return "dezenove";
                    default: return "";
                }
            }
            else
            {
                if (unidade == '0')
                {
                    return Dezenas(dezena);
                }
                else
                {
                    return Dezenas(dezena) + " e " + Unidades(unidade);
                }
            }
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
