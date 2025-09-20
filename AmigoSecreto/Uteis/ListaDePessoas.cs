using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto.Uteis
{
    public class ListaDePessoas
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public bool Adicionar(string nome)
        {
            // Verifica se o nome já existe
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Nome == nome)
                {
                    return false; // não adiciona nome repetido
                }
            }

            Pessoa p = new()
            {
                Nome = nome
            };
            pessoas.Add(p);
            return true;
        }


        public void Mostrar()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
            }
            else
            {
                for (int i = 0; i < pessoas.Count; i++)
                {
                    Console.WriteLine(pessoas[i].Nome);
                }
            }
        }

        public bool Remover(string nome)
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Nome == nome)
                {
                    pessoas.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Pessoa> GetPessoas()
        {
            return pessoas;
        }
    }
}