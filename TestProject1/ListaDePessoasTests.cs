using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoSecreto.Uteis;
using System.Collections.Generic;

namespace TestProject1
{
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
    }
}
