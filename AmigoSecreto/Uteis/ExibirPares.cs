
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoSecreto.Uteis;

namespace AmigoSecreto.uteis
{
    public class ExibirPares
    {
        public void Mostrar(List<Pares> pares)
        {
            if (pares.Count == 0)
            {
                Console.WriteLine("Nenhum par sorteado ainda.");
            }
            else
            {
                for (int i = 0; i < pares.Count; i++)
                {
                    Console.WriteLine(pares[i].Pessoa1.Nome + " -> " + pares[i].Pessoa2.Nome);
                }
            }
        }
    }
}
