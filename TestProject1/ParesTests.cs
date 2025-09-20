using AmigoSecreto.Uteis;

[TestClass]
public class ParesTests
{
    [TestMethod]
    public void DeveCriarParComDuasPessoas()
    {
        // ===== CENÁRIO =====
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Maria";
        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "João";

        // ===== AÇÃO =====
        Pares par = new Pares();
        par.Pessoa1 = pessoa1;
        par.Pessoa2 = pessoa2;

        // ===== VALIDAÇÃO =====
        Assert.IsNotNull(par.Pessoa1);
        Assert.IsNotNull(par.Pessoa2);
        Assert.AreEqual("Maria", par.Pessoa1.Nome);
        Assert.AreEqual("João", par.Pessoa2.Nome);
    }
}
