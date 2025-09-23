using System;
using System.Collections.Generic;
using System.Linq;

namespace AmigoSecreto.Uteis
{
    public class Sorteio
    {
        public List<Pares> Sortear(List<Pessoa> pessoas)
        {
            if (pessoas.Count < 3)
            {
                throw new InvalidOperationException("É necessário pelo menos 3 pessoas para o sorteio.");
            }

            Random aleatorio = new Random();

            // embaralhar
            List<Pessoa> embaralhados = pessoas.OrderBy(p => aleatorio.Next()).ToList();

            List<Pares> resultado = new List<Pares>();

            for (int i = 0; i < embaralhados.Count; i++)
            {
                Pessoa doador = embaralhados[i];
                Pessoa receptor = embaralhados[(i + 1) % embaralhados.Count]; // próximo da lista
                resultado.Add(new Pares { Pessoa1 = doador, Pessoa2 = receptor });
            }

            return resultado;
        }
    }
}
