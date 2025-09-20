using AmigoSecreto.Uteis;

[TestClass]
public class ListaDePessoasTests
{
    [TestMethod]
    public void Adicionar_NovoNome_DeveFuncionar()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();

        // ===== AÇÃO =====
        bool resultado = lista.Adicionar("Maria");

        // ===== VALIDAÇÃO =====
        Assert.IsTrue(resultado);
        Assert.AreEqual(1, lista.GetPessoas().Count);
        Assert.AreEqual("Maria", lista.GetPessoas()[0].Nome);
    }

    [TestMethod]
    public void Adicionar_NomeRepetido_DeveRetornarFalse()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();
        lista.Adicionar("Maria");

        // ===== AÇÃO =====
        bool resultado = lista.Adicionar("Maria");

        // ===== VALIDAÇÃO =====
        Assert.IsFalse(resultado);
        Assert.AreEqual(1, lista.GetPessoas().Count);
    }

    [TestMethod]
    public void Remover_NomeExistente_DeveFuncionar()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();
        lista.Adicionar("Maria");

        // ===== AÇÃO =====
        bool resultado = lista.Remover("Maria");

        // ===== VALIDAÇÃO =====
        Assert.IsTrue(resultado);
        Assert.AreEqual(0, lista.GetPessoas().Count);
    }

    [TestMethod]
    public void Remover_NomeInexistente_DeveRetornarFalse()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();
        lista.Adicionar("Maria");

        // ===== AÇÃO =====
        bool resultado = lista.Remover("João");

        // ===== VALIDAÇÃO =====
        Assert.IsFalse(resultado);
        Assert.AreEqual(1, lista.GetPessoas().Count);
    }

    [TestMethod]
    public void Mostrar_ListaVazia_DeveExibirMensagem()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();
        System.IO.StringWriter sw = new System.IO.StringWriter();
        Console.SetOut(sw);

        // ===== AÇÃO =====
        lista.Mostrar();

        // ===== VALIDAÇÃO =====
        string saida = sw.ToString().Trim();
        Assert.AreEqual("Nenhuma pessoa cadastrada.", saida);
    }

    [TestMethod]
    public void Mostrar_ListaComPessoas_DeveExibirNomes()
    {
        // ===== CENÁRIO =====
        ListaDePessoas lista = new ListaDePessoas();
        lista.Adicionar("Maria");
        lista.Adicionar("João");
        System.IO.StringWriter sw = new System.IO.StringWriter();
        Console.SetOut(sw);

        // ===== AÇÃO =====
        lista.Mostrar();

        // ===== VALIDAÇÃO =====
        string saida = sw.ToString().Trim();
        string esperado = "Maria" + Environment.NewLine + "João";
        Assert.AreEqual(esperado, saida);
    }
}
