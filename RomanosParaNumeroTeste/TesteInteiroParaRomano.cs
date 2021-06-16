using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ClassLibrary;


namespace RomanosParaNumeroTeste
{

    [TestClass]
    public class TesteInteiroParaRomano
    {

        InteiroParaRomano inteiro = new InteiroParaRomano();

        [TestMethod]
        public void DeveRetornarI()
        {
            int numero = 1;

            Assert.AreEqual("I", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar4()
        {
            int numero = 4;

            Assert.AreEqual("IV", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar9()
        {
            int numero = 9;

            Assert.AreEqual("IX", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar14()
        {
            int numero = 14;

            Assert.AreEqual("XIV", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar17()
        {
            int numero = 17;

            Assert.AreEqual("XVII", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar20()
        {
            int numero = 20;

            Assert.AreEqual("XX", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar29()
        {
            int numero = 29;

            Assert.AreEqual("XXIX", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar31()
        {
            int numero = 31;

            Assert.AreEqual("XXXI", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar38()
        {
            int numero = 38;

            Assert.AreEqual("XXXVIII", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar48()
        {
            int numero = 48;

            Assert.AreEqual("XLVIII", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            int numero = 50;

            Assert.AreEqual("L", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar64()
        {
            int numero = 64;

            Assert.AreEqual("LXIV", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar72()
        {
            int numero = 72;

            Assert.AreEqual("LXXII", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar85()
        {
            int numero = 85;

            Assert.AreEqual("LXXXV", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar90()
        {
            int numero = 90;

            Assert.AreEqual("XC", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar108()
        {
            int numero = 108;

            Assert.AreEqual("CVIII", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar139()
        {
            int numero = 139;

            Assert.AreEqual("CXXXIX", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar555()
        {
            int numero = 555;

            Assert.AreEqual("DLV", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar1500()
        {
            int numero = 1500;

            Assert.AreEqual("MD", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar4500()
        {
            int numero = 4500;

            Assert.AreEqual("ĪV̄D", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar4mil()
        {
            int numero = 4000;

            Assert.AreEqual("ĪV̄", inteiro.ConverteInteiroParaRomano(numero));
        }

        [TestMethod]
        public void DeveRetornar5mil()
        {
            int numero = 5000;

            Assert.AreEqual("V̄", inteiro.ConverteInteiroParaRomano(numero));
        }
    }
}
