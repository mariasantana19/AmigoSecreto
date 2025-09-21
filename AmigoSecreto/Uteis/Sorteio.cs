using System;
using System.Collections.Generic;
using System.Linq;
using AmigoSecreto.Uteis;

namespace AmigoSecreto.uteis
{
    public class Sorteio
    {
        public List<Pares> Sortear(List<Pessoa> pessoas)
        {
            if (pessoas.Count < 3)
            {
                throw new InvalidOperationException("É necessário pelo menos 3 pessoas para o sorteio.");
            }

            List<Pessoa> receptoresDisponiveis = new List<Pessoa>(pessoas);
            Random aleatorio = new Random();
            List<Pares> resultado = new List<Pares>();

            for (int i = 0; i < pessoas.Count; i++)
            {
                Pessoa doador = pessoas[i];
                Pessoa receptor;
                int indexSorteado;

                do
                {
                    indexSorteado = aleatorio.Next(receptoresDisponiveis.Count);
                    receptor = receptoresDisponiveis[indexSorteado];
                }
                while (receptor == doador || resultado.Any(p => p.Pessoa1 == receptor && p.Pessoa2 == doador));

                Pares novoPar = new Pares();
                novoPar.Pessoa1 = doador;
                novoPar.Pessoa2 = receptor;
                resultado.Add(novoPar);

                receptoresDisponiveis.RemoveAt(indexSorteado);
            }

            return resultado;
        }
    }
}