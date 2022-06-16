using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double num1 = 1;
            double num2 = 1;
            double rnum = 2;

            //Act - A��o
            var resultado = Operacoes.Somar(num1, num2);

            //Assert - Verifica��o
            Assert.AreEqual(rnum, resultado);
        }


        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 3, 2)]
        public void SomarLista(double num1, double num2, double rnum)
        {
            //Act - A��o
            var resultado = Operacoes.Somar(num1, num2);

            //Assert - Verifica��o
            Assert.AreEqual(rnum, resultado);
        }
    }
}