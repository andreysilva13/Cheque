using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cheque.ConsoleApp;

namespace Teste
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TesteCentavos()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(0.50);
            string resultado1 = valor.PegaValor(0.01);
            string resultado2 = valor.PegaValor(0.11);
            Assert.AreEqual("cinquenta centavos", resultado);
            Assert.AreEqual("um centavo", resultado1);
            Assert.AreEqual("onze centavos", resultado2);
        }

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
        public void TesteUnidadeCentavo()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(1.50);
            string resultado1 = valor.PegaValor(1.01);
            Assert.AreEqual("um real e cinquenta centavos", resultado);
            Assert.AreEqual("um real e um centavo", resultado1);
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
        public void TesteDezenaCentavo()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(21.50);
            string resultado1 = valor.PegaValor(10.01);

            Assert.AreEqual("vinte e um reais e cinquenta centavos", resultado);
            Assert.AreEqual("dez reais e um centavo", resultado1);
        }

        [TestMethod]
        public void TesteCentena()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(100);
            string resultado1 = valor.PegaValor(345);
            string resultado2 = valor.PegaValor(102);

            Assert.AreEqual("cem reais", resultado);
            Assert.AreEqual("trezentos e quarenta e cinco reais", resultado1);
            Assert.AreEqual("cento e dois reais", resultado2);
        }

        [TestMethod]
        public void TesteCentenaCentavos()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(100.50);
            string resultado1 = valor.PegaValor(345.01);
            string resultado2 = valor.PegaValor(102.11);

            Assert.AreEqual("cem reais e cinquenta centavos", resultado);
            Assert.AreEqual("trezentos e quarenta e cinco reais e um centavo", resultado1);
            Assert.AreEqual("cento e dois reais e onze centavos", resultado2);
        }

        [TestMethod]
        public void TesteUnidadeMilhar()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(1000);
            string resultado1 = valor.PegaValor(1001);
            string resultado2 = valor.PegaValor(1010);
            string resultado3 = valor.PegaValor(1110);
            string resultado4 = valor.PegaValor(1101);
            string resultado5 = valor.PegaValor(3454);

            Assert.AreEqual("um mil reais", resultado);
            Assert.AreEqual("um mil e um reais", resultado1);
            Assert.AreEqual("um mil e dez reais", resultado2);
            Assert.AreEqual("um mil cento e dez reais", resultado3);
            Assert.AreEqual("um mil cento e um reais", resultado4);
            Assert.AreEqual("três mil quatrocentos e cinquenta e quatro reais", resultado5);
        }
        
        [TestMethod]
        public void TesteUnidadeMilharCentavos()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(1000.50);
            string resultado1 = valor.PegaValor(1001.01);
            string resultado2 = valor.PegaValor(3454.33);

            Assert.AreEqual("um mil reais e cinquenta centavos", resultado);
            Assert.AreEqual("um mil e um reais e um centavo", resultado1);
            Assert.AreEqual("três mil quatrocentos e cinquenta e quatro reais e trinta e três centavos", resultado2);
        }

        [TestMethod]
        public void ValorInvalido()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(0);
            string resultado1 = valor.PegaValor(1001.01);
            string resultado2 = valor.PegaValor(3454.33);

            Assert.AreEqual("Valor inválido", resultado);
        }
    }
}
