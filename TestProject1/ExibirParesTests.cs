using AmigoSecreto.uteis;
using AmigoSecreto.Uteis;

[TestClass]
public class ExibirParesTests
{
    [TestMethod]
    public void Mostrar_ListaVazia_NaoGeraErro()
    {
        // ===== CENÁRIO =====
        ExibirPares exibir = new ExibirPares();
        List<Pares> pares = new List<Pares>();

        // ===== AÇÃO / VALIDAÇÃO =====
        // Só verificar que o método roda sem lançar exceção
        exibir.Mostrar(pares);
    }

    [TestMethod]
    public void Mostrar_ListaComUmPar_NaoGeraErro()
    {
        // ===== CENÁRIO =====
        ExibirPares exibir = new ExibirPares();
        List<Pares> pares = new List<Pares>();
        Pessoa p1 = new Pessoa();
        p1.Nome = "Maria";
        Pessoa p2 = new Pessoa();
        p2.Nome = "João";
        Pares par = new Pares();
        par.Pessoa1 = p1;
        par.Pessoa2 = p2;
        pares.Add(par);

        // ===== AÇÃO / VALIDAÇÃO =====
        // Só verificar que o método roda sem lançar exceção
        exibir.Mostrar(pares);
    }
}
