using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{
    public abstract class TratamentoValores : ValorBase
    {   

        public string UMilharCentenaDezenaUnidade(char uMilhar, char centena, char dezena, char unidade)
        {
            if (uMilhar == '0')
            {
                return Centenas(centena) + " e " + DezenaUnidade(dezena, unidade);
            }
            else if(centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil";
            }

            else if (centena == '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil e " + Unidades(unidade);
            }

            else if (centena != '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil " + Centenas(centena) + " e " + Dezenas(dezena);
            }

            else if (centena != '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil " + Centenas(centena) + " e " + Unidades(unidade);
            }

            else if (centena == '0' && dezena != '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil " + DezenaUnidade(dezena, unidade);
            }

            else if (centena == '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil e " + Dezenas(dezena);
            }
            else
            {
                return Unidades(uMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
        }
        public string CentenaDezenaUnidade(char centena, char dezena, char unidade)
        {
            if (centena == '1' && dezena == '0' && unidade == '0')
            {
                return "cem";
            }
            else if (dezena == '0' && unidade == '0')
            {
                return Centenas(centena);
            }
            else if (centena == '0')
            {
                return "e " + DezenaUnidade(dezena, unidade);
            }
            else if (dezena == '0' && unidade != '0')
            {
                return Centenas(centena) + " e " + Unidades(unidade);
            }
            else
            {
                return Centenas(centena) + " e " + DezenaUnidade(dezena, unidade);
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
    }
}
