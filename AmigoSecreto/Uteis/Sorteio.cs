
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoSecreto.Uteis;

namespace AmigoSecreto.uteis
{
    public class Sorteio
    {
        public List<Pares> Sortear(List<Pessoa> pessoas)
        {
            List<Pessoa> copia = new List<Pessoa>();
            for (int i = 0; i < pessoas.Count; i++)
            {
                copia.Add(pessoas[i]);
            }

            Random aleatorio = new Random();
            List<Pares> resultado = new List<Pares>();

            for (int i = 0; i < pessoas.Count; i++)
            {
                Pessoa participante = pessoas[i];
                int indexSorteado;
                Pessoa amigo;

                do
                {
                    indexSorteado = aleatorio.Next(copia.Count);
                    amigo = copia[indexSorteado];
                }
                while (amigo == participante);

                Pares par = new Pares();
                par.Pessoa1 = participante;
                par.Pessoa2 = amigo;
                resultado.Add(par);

                copia.RemoveAt(indexSorteado);
            }

            return resultado;
        }
    }
}
