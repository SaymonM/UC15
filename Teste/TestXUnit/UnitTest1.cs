using Teste;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Somar2Num()
        {
            //Arrange
            double num1 = 1;
            double num2 = 1;
            double rnum = 2;

            //Act
            var resultado = Operacoes.Somar(num1, num2);

            //Assert
            Assert.Equal(rnum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 12, 2)]
        [InlineData(1, 3, 2)]
        public void SomarLista(double num1, double num2, double rnum)
        {
            //Act
            var resultado = Operacoes.Somar(num1, num2);

            //Assert
            Assert.Equal(rnum, resultado);
        }
    }
}