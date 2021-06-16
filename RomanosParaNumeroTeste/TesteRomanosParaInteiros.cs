using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ClassLibrary;


namespace RomanosParaNumeroTeste
{
    [TestClass]
    public class TesteRomanosParaInteiros
    {
        RomanoParaInteiro romano = new RomanoParaInteiro();

        [TestMethod]
        public void DeveRetornar1()
        {
            string numero = "I";

            Assert.AreEqual(1, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar2()
        {
            string numero = "II";

            Assert.AreEqual(2, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar4()
        {
            string numero = "IV";

            Assert.AreEqual(4, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar9()
        {
            string numero = "IX";

            Assert.AreEqual(9, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar14()
        {
            string numero = "XIV";

            Assert.AreEqual(14, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar17()
        {
            string numero = "XVII";

            Assert.AreEqual(17, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar20()
        {
            string numero = "XX";

            Assert.AreEqual(20, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar29()
        {
            string numero = "XXIX";

            Assert.AreEqual(29, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar31()
        {
            string numero = "XXXI";

            Assert.AreEqual(31, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar38()
        {
            string numero = "XXXVIII";

            Assert.AreEqual(38, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar48()
        {
            string numero = "XLVIII";

            Assert.AreEqual(48, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            string numero = "L";

            Assert.AreEqual(50, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar64()
        {
            string numero = "LXIV";

            Assert.AreEqual(64, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar72()
        {
            string numero = "LXXII";

            Assert.AreEqual(72, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar85()
        {
            string numero = "LXXXV";

            Assert.AreEqual(85, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar90()
        {
            string numero = "XC";

            Assert.AreEqual(90, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar108()
        {
            string numero = "CVIII";

            Assert.AreEqual(108, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar139()
        {
            string numero = "CXXXIX";

            Assert.AreEqual(139, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar555()
        {
            string numero = "DLV";

            Assert.AreEqual(555, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar1500()
        {
            string numero = "MD";

            Assert.AreEqual(1500, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar4500ComTracinho()
        {
            string numero = "ĪV̄D";

            Assert.AreEqual(4500, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar4milComTracinho()
        {
            string numero = "ĪV̄";

            Assert.AreEqual(4000, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar5mil()
        {
            string numero = "V̄";

            Assert.AreEqual(5000, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }

        [TestMethod]
        public void DeveRetornar10mil()
        {
            string numero = "X̄";

            Assert.AreEqual(10000, romano.ConverteRomanoParaInteiroraInteiro(numero));
        }
    }
}
