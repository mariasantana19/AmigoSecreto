using AmigoSecreto.Uteis;

[TestClass]
public class PessoaTests
{
    [TestMethod]
    public void DeveCriarPessoaComNome()
    {
        // ===== CENÁRIO =====
        Pessoa pessoa = new Pessoa();

        // ===== AÇÃO =====
        pessoa.Nome = "Maria";

        // ===== VALIDAÇÃO =====
        Assert.IsNotNull(pessoa);
        Assert.AreEqual("Maria", pessoa.Nome);
    }
}
