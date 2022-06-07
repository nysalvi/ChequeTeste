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
        public void Dezena()
        {

        }
        [TestMethod]
        public void Centena()
        {

        }
        [TestMethod]
        public void Milhar()
        {

        }
        [TestMethod]
        public void Milhao()
        {

        }
    }
}
