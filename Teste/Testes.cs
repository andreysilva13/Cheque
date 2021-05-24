using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cheque.ConsoleApp;

namespace Teste
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TesteUnidade()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(2);
            string resultado1 = valor.PegaValor(1);
            Assert.AreEqual("dois reais", resultado);
            Assert.AreEqual("um real", resultado1);
        }

        [TestMethod]
        public void TesteDezena()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(21);
            string resultado1 = valor.PegaValor(65);
            string resultado2 = valor.PegaValor(11);

            Assert.AreEqual("vinte e um reais", resultado);
            Assert.AreEqual("sessenta e cinco reais", resultado1);
            Assert.AreEqual("onze reais", resultado2);
        }

        [TestMethod]
        public void TesteCentena()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(100);
            string resultado1 = valor.PegaValor(345);
            string resultado2 = valor.PegaValor(102);

            Assert.AreEqual("cem", resultado);
            Assert.AreEqual("trezentos e quarenta e cinco", resultado1);
            Assert.AreEqual("cento e dois", resultado2);
        }


    }
}
