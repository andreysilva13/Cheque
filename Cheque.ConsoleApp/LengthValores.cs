using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{
    public class LengthValores : TratamentoValores
    {
        string reais = null;
        public string Converter(string valor)
        {
            if (valor.Length == 1)
            {
                reais = Unidades(valor.ToCharArray()[0]);
                return reais;
            }

            if (valor.Length == 2)
            {
                reais = DezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1]);
                return reais;
            }

            if (valor.Length == 3)
            {
                reais = CentenaDezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2]);
                return reais;
            }

            if (valor.Length == 4)
            {
                reais = UMilharCentenaDezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3]);
                return reais;
            }

            if (valor.Length == 5)
            {
                reais = DMilharUMilharCentenaDezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4]);
                return reais;
            }

            if (valor.Length == 6)
            {
                reais = CMilharDMilharUMilharCentenaDezenaUnidade(valor.ToCharArray()[0], valor.ToCharArray()[1], valor.ToCharArray()[2], valor.ToCharArray()[3], valor.ToCharArray()[4], valor.ToCharArray()[5]);
                return reais;
            }

            return reais;
        }     
    }
}

