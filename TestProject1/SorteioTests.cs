using AmigoSecreto.uteis;
using AmigoSecreto.Uteis;

[TestClass]
public class SorteioTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Sortear_MenosDeDuasPessoas_LancaExcecao()
    {
        // ===== CENÁRIO =====
        Sorteio sorteio = new Sorteio();
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(new Pessoa { Nome = "Maria" });

        // ===== AÇÃO =====
        sorteio.Sortear(pessoas);

        // ===== VALIDAÇÃO =====
        // Exceção é verificada pelo ExpectedException
    }

    [TestMethod]
    public void Sortear_ComDuasOuMaisPessoas_RetornaPares()
    {
        // ===== CENÁRIO =====
        Sorteio sorteio = new Sorteio();
        List<Pessoa> pessoas = new List<Pessoa>();
        Pessoa pessoa1 = new Pessoa(); pessoa1.Nome = "Maria";
        Pessoa pessoa2 = new Pessoa(); pessoa2.Nome = "João";
        Pessoa pessoa3 = new Pessoa(); pessoa3.Nome = "Ana";
        pessoas.Add(pessoa1);
        pessoas.Add(pessoa2);
        pessoas.Add(pessoa3);

        // ===== AÇÃO =====
        List<Pares> resultado = sorteio.Sortear(pessoas);

        // ===== VALIDAÇÃO =====
        Assert.AreEqual(pessoas.Count, resultado.Count);

        for (int i = 0; i < resultado.Count; i++)
        {
            Assert.AreNotEqual(resultado[i].Pessoa1, resultado[i].Pessoa2);
        }
    }
}
