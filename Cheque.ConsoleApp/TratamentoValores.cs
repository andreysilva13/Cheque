using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{
    public abstract class TratamentoValores : ValorBase
    {   
        public string UBilhao(char uBilhao, char cMilhao, char dMilhao, char uMilhao, char cMilhar, char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {
            if (uBilhao == '1' && cMilhao == '0' && dMilhao == '0' && uMilhao == '0' && cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uBilhao) + " bilhão de";
            }
            else if (uBilhao == '1' && (cMilhao != '0' || dMilhao != '0' || uMilhao != '0'))
            {
                return Unidades(uBilhao) + " bilhao " + CMilhao(cMilhao, dMilhao, uMilhao, cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
            }
            else if (cMilhao == '0' && dMilhao == '0' && uMilhao == '0' && cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uBilhao) + " bilhões de";
            }
            else if (cMilhao != '0' || dMilhao != '0' || uMilhao != '0')
            {
                return Unidades(uBilhao) + " bilhões e " + CMilhao(cMilhao, dMilhao, uMilhao, cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
            }
            else
                return Unidades(uBilhao) + " bilhões e " + Centenas(cMilhao) + Dezenas(dMilhao) + Unidades(uMilhao) + Centenas(cMilhar) + Dezenas(dMilhar) + Unidades(uMilhar) + Centenas(centena) + Dezenas(dezena) + Unidades(unidade);

        }
        public string CMilhao(char cMilhao, char dMilhao, char uMilhao, char cMilhar, char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {
            if (cMilhao == '1' && dMilhao == '0' && uMilhao == '0' && cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return "cem milhões de";
            }
            else if (cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return CentenaDezenaUnidade(cMilhao, dMilhao, uMilhao) + " milhões de";
            }
            else if (cMilhar == '0' && dMilhar == '0' && uMilhar == '0')
            {
                return CentenaDezenaUnidade(cMilhao, dMilhao, uMilhao) + " milhões " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
            else
                return CentenaDezenaUnidade(cMilhao, dMilhao, uMilhao) + " milhões e " + CMilharDMilharUMilharCentenaDezenaUnidade(cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
        }
        public string DMilhao(char dMilhao, char uMilhao, char cMilhar, char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {
            if (cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return DezenaUnidade(dMilhao, uMilhao) + " milhões de";
            } else if (cMilhar == '0' && dMilhar == '0' && uMilhar == '0')
            {
                return DezenaUnidade(dMilhao, uMilhao) + " milhões " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
            else
                return DezenaUnidade(dMilhao, uMilhao) + " milhões " + CMilharDMilharUMilharCentenaDezenaUnidade(cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
        }
        public string UMilhao(char uMilhao, char cMilhar, char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {
            //MILHAO
            if (uMilhao == '1' && cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uMilhao) + " milhão de";
            }
            else if (uMilhao == '1' && (cMilhar != '0' || dMilhar != '0' || uMilhar != '0'))
            {
                return Unidades(uMilhao) + " milhão " + CMilharDMilharUMilharCentenaDezenaUnidade(cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
            }
            else if (cMilhar == '0' && dMilhar == '0' && uMilhar == '0' && centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uMilhao) + " milhões de";
            }
            else if(cMilhar != '0' || dMilhar != '0' || uMilhar != '0')
            {
                return Unidades(uMilhao) + " milhões " + CMilharDMilharUMilharCentenaDezenaUnidade(cMilhar, dMilhar, uMilhar, centena, dezena, unidade);
            }
            else
                return Unidades(uMilhao) + " milhões " + Centenas(cMilhar) + Dezenas(dMilhar) + Unidades(uMilhar) + Centenas(centena) + Dezenas(dezena) + Unidades(unidade);
        }
        public string CMilharDMilharUMilharCentenaDezenaUnidade(char cMilhar, char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {   
            if(dMilhar == '0' && uMilhar == '0')
            {
                return CentenaDezenaUnidade(cMilhar, dMilhar, uMilhar) + " mil e " + Centenas(centena);

            } else if (dMilhar == '0' && uMilhar == '0')
            {
                return CentenaDezenaUnidade(cMilhar, dMilhar, cMilhar) + " mil e " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
            else if (centena != 0 && dezena == '0' && unidade == '0')
            {
                return DezenaUnidade(dMilhar, uMilhar) + " mil " + "e " + Centenas(centena);
            }
            else
            {
                return CentenaDezenaUnidade(cMilhar, dMilhar, uMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
        }
        public string DMilharUMilharCentenaDezenaUnidade(char dMilhar, char uMilhar, char centena, char dezena, char unidade)
        {
            if (dezena == '0' && unidade == '0')
            {
                return DezenaUnidade(dMilhar, uMilhar) + " mil" + Centenas(centena);
            }
            else if (centena != 0 && dezena == '0' && unidade == '0')
            {
                return DezenaUnidade(dMilhar, uMilhar) + " mil " + "e " + Centenas(centena);
            }
            else
            {
                return DezenaUnidade(dMilhar, uMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
        }
        public string UMilharCentenaDezenaUnidade(char uMilhar, char centena, char dezena, char unidade)
        {   
            //1000
            if(centena == '0' && dezena == '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil";
            }
            //1001
            else if (centena == '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil e " + Unidades(unidade);
            }
            //1110
            else if (centena != '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil " + Centenas(centena) + " e " + Dezenas(dezena);
            }
            //1101
            else if (centena != '0' && dezena == '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil " + Centenas(centena) + " e " + Unidades(unidade);
            }
            //1011
            else if (centena == '0' && dezena != '0' && unidade != '0')
            {
                return Unidades(uMilhar) + " mil " + DezenaUnidade(dezena, unidade);
            }
            //1010
            else if (centena == '0' && dezena != '0' && unidade == '0')
            {
                return Unidades(uMilhar) + " mil e " + Dezenas(dezena);
            }
            //1111
            else
            {
                return Unidades(uMilhar) + " mil " + CentenaDezenaUnidade(centena, dezena, unidade);
            }
        }
        public string CentenaDezenaUnidade(char centena, char dezena, char unidade)
        {   
            //100
            if (centena == '1' && dezena == '0' && unidade == '0')
            {
                return "cem";
            }
            //200...
            else if (dezena == '0' && unidade == '0')
            {
                return Centenas(centena);
            }
            //101...
            else if (dezena == '0' && unidade != '0')
            {
                return Centenas(centena) + " e " + Unidades(unidade);
            }
            //111
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
