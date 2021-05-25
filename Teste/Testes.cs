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
        public void TesteDezenaMilhar()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(10000);
            string resultado1 = valor.PegaValor(11111);
            string resultado2 = valor.PegaValor(25464);

            Assert.AreEqual("dez mil reais", resultado);
            Assert.AreEqual("onze mil cento e onze reais", resultado1);
            Assert.AreEqual("vinte e cinco mil quatrocentos e sessenta e quatro reais", resultado2);
        }

        [TestMethod]
        public void TesteDezenaMilharCentavos()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(10000.50);
            string resultado1 = valor.PegaValor(11111.22);
            string resultado2 = valor.PegaValor(25464.83);

            Assert.AreEqual("dez mil reais e cinquenta centavos", resultado);
            Assert.AreEqual("onze mil cento e onze reais e vinte e dois centavos", resultado1);
            Assert.AreEqual("vinte e cinco mil quatrocentos e sessenta e quatro reais e oitenta e três centavos", resultado2);
        }

        [TestMethod]
        public void TesteCentenaMilhar()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(100000);
            string resultado1 = valor.PegaValor(111111);
            string resultado2 = valor.PegaValor(525464);

            Assert.AreEqual("cem mil reais", resultado);
            Assert.AreEqual("cento e onze mil cento e onze reais", resultado1);
            Assert.AreEqual("quinhentos e vinte e cinco mil quatrocentos e sessenta e quatro reais", resultado2);
        }

        [TestMethod]
        public void TesteCentenaMilharCentavos()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(100000.20);
            string resultado1 = valor.PegaValor(111111.01);

            Assert.AreEqual("cem mil reais e vinte centavos", resultado);
            Assert.AreEqual("cento e onze mil cento e onze reais e um centavo", resultado1);
        }

        [TestMethod]
        public void TesteUMilhao()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(1000000);
            string resultado1 = valor.PegaValor(1111111);
            string resultado2 = valor.PegaValor(5000000);
            string resultado3 = valor.PegaValor(2525464);

            Assert.AreEqual("um milhão de reais", resultado);
            Assert.AreEqual("um milhão cento e onze mil cento e onze reais", resultado1);
            Assert.AreEqual("cinco milhões de reais", resultado2);
            Assert.AreEqual("dois milhões quinhentos e vinte e cinco mil quatrocentos e sessenta e quatro reais", resultado3);
        }

        [TestMethod]
        public void TesteDMilhao()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(25000000);
            string resultado2 = valor.PegaValor(25342555);
            string resultado3 = valor.PegaValor(25000555);

            Assert.AreEqual("vinte e cinco milhões de reais", resultado);
            Assert.AreEqual("vinte e cinco milhões trezentos e quarenta e dois mil quinhentos e cinquenta e cinco reais", resultado2);
            Assert.AreEqual("vinte e cinco milhões quinhentos e cinquenta e cinco reais", resultado3);
        }

        [TestMethod]
        public void TesteCMilhao()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(250000000);
            string resultado2 = valor.PegaValor(250342555);
            string resultado3 = valor.PegaValor(252000555);

            Assert.AreEqual("duzentos e cinquenta milhões de reais", resultado);
            Assert.AreEqual("duzentos e cinquenta milhões trezentos e quarenta e dois mil quinhentos e cinquenta e cinco reais", resultado2);
            Assert.AreEqual("duzentos e cinquenta e dois milhões quinhentos e cinquenta e cinco reais", resultado3);
        }

        [TestMethod]
        public void TesteBilhao()
        {
            ValorBase valor = new ValorBase();

            string resultado = valor.PegaValor(1000000000);
            string resultado2 = valor.PegaValor(9000000000);
            string resultado3 = valor.PegaValor(9500500500);

            Assert.AreEqual("um bilhão de reais", resultado);
            Assert.AreEqual("nove bilhões de reais", resultado2);
            Assert.AreEqual("nove bilhões e quinhentos milhões e quinhentos mil e quinhentos reais", resultado3);
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
