using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequeExtenso.ConsoleApp;
namespace ChequeTeste.Test
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {

        }
        [TestMethod]
        [DataRow("1", "um")]
        [DataRow("2", "dois")]
        [DataRow("3", "três")]
        [DataRow("4", "quatro")]
        [DataRow("5", "cinco")]
        [DataRow("6", "seis")]
        [DataRow("7", "sete")]
        [DataRow("8", "oito")]
        [DataRow("9", "nove")]
        public void Unidade(string numero, string numeroEscrito)
        {
            Cheque cheque = new Cheque(numero);
            string resul = cheque.CalculaValor();
            Assert.AreEqual(resul, numeroEscrito);            
        }
        [TestMethod]
        [DataRow("10", "dez")]
        [DataRow("11", "onze")]
        [DataRow("12", "doze")]
        [DataRow("13", "treze")]
        [DataRow("14", "catorze")]
        [DataRow("15", "quinze")]
        [DataRow("16", "dezesseis")]
        [DataRow("17", "dezessete")]
        [DataRow("18", "dezoito")]
        [DataRow("19", "dezenove")]
        public void Dezena(string numero, string numeroEscrito)
        {
            Cheque cheque = new Cheque(numero);
            string resul = cheque.CalculaValor();
            Assert.AreEqual(resul, numeroEscrito);
        }
        [TestMethod]
        [DataRow("100", "cem")]
        [DataRow("243", "duzentosquarentatrês")]
        [DataRow("339", "trezentostrintanove")]
        [DataRow("012", "doze")]
        [DataRow("008", "oito")]
        [DataRow("600", "seiscentos")]
        [DataRow("542", "quinhentosquarentadois")]
        [DataRow("881", "oitocentosoitentaum")]
        public void Centena(string numero, string numeroEscrito)
        {
            Cheque cheque = new Cheque(numero);
            string resul = cheque.CalculaValor();
            Assert.AreEqual(resul, numeroEscrito);
        }
        [TestMethod]
        [DataRow("0100", "cem")]
        [DataRow("0203", "duzentostrês")]
        [DataRow("1039", "miltrintanove")]
        [DataRow("012", "doze")]
        [DataRow("008", "oito")]
        [DataRow("600", "seiscentos")]
        [DataRow("542", "quinhentosquarentadois")]
        [DataRow("881", "oitocentosoitentaum")]
        public void Milhar(string numero, string numeroEscrito)
        {
            Cheque cheque = new Cheque(numero);
            string resul = cheque.CalculaValor();
            Assert.AreEqual(resul, numeroEscrito);
        }
        [TestMethod]
        public void Milhao(string numero, string numeroEscrito)
        {
            Cheque cheque = new Cheque(numero);
            string resul = cheque.CalculaValor();
            Assert.AreEqual(resul, numeroEscrito);
        }
    }
}
