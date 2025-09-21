using System;
using System.Collections.Generic;
using AmigoSecreto.uteis;
using AmigoSecreto.Uteis;

ListaDePessoas lista = new ListaDePessoas();
Sorteio sorteio = new Sorteio();
ExibirPares exibir = new ExibirPares();
List<Pares> paresSorteados = new List<Pares>();

bool sorteioFeito = false;
int opcao = -1;

do
{
    Console.WriteLine("\n===== MENU AMIGO OCULTO =====");
    Console.WriteLine("[0] - Sair");

    if (!sorteioFeito)
    {
        Console.WriteLine("[1] - Adicionar pessoas");
        Console.WriteLine("[2] - Mostrar pessoas cadastradas");
        Console.WriteLine("[3] - Sortear amigo oculto");
        Console.WriteLine("[5] - Remover pessoa");
    }
    else
    {
        Console.WriteLine("[4] - Mostrar pares sorteados");
    }

    Console.Write("Escolha uma opção: ");
    try
    {
        opcao = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Digite apenas números!");
        continue;
    }

    if (!sorteioFeito)
    {
        if (opcao == 1)
        {
            Console.Write("Digite os nomes separados por vírgula: ");
            string entrada = Console.ReadLine();
            string[] nomes = entrada.Split(',');
            Console.WriteLine("Nomes adicionados com sucesso!");


            for (int i = 0; i < nomes.Length; i++)
            {
                string nomeLimpo = nomes[i].Trim();
                if (nomeLimpo != "")
                {
                    bool adicionado = lista.Adicionar(nomeLimpo);
                    if (!adicionado)
                    {
                        Console.WriteLine($"O nome '{nomeLimpo}' já está na lista e não foi adicionado.");
                    }
                }
            }
        }
        else if (opcao == 2)
        {
            lista.Mostrar();
        }
        else if (opcao == 3)
        {
            List<Pessoa> pessoas = lista.GetPessoas();
            Console.WriteLine("Pessoas cadastradas: " + pessoas.Count);

            if (pessoas.Count < 2)
            {
                Console.WriteLine("É necessário pelo menos 2 pessoas para sortear.");
            }
            else
            {
                paresSorteados = sorteio.Sortear(pessoas);
                sorteioFeito = true;
                Console.WriteLine("Sorteio realizado!");
            }
        }
        else if (opcao == 5)
        {
            Console.Write("Digite o nome da pessoa que deseja remover: ");
            string nomeRemover = Console.ReadLine().Trim();
            bool removido = lista.Remover(nomeRemover);
            if (removido)
                Console.WriteLine(nomeRemover + " foi removido da lista.");
            else
                Console.WriteLine(nomeRemover + " não está na lista.");
        }
        else if (opcao != 0)
        {
            Console.WriteLine("Opção inválida!");
        }
    }
    else
    {
        if (opcao == 4)
        {
            exibir.Mostrar(paresSorteados);
        }
        else if (opcao != 0)
        {
            Console.WriteLine("Opção inválida!");
        }
    }

} while (opcao != 0);
