using CalculatorApp;

namespace Calculator.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            //Arrange
            var calculator = new MathFormulas();

            int x = 2;
            int y = 2;
           //Act
            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);
           //Assert
            Assert.True(xResult);
            Assert.True(yResult);
        }
        [Theory]
        [InlineData(1,2,5)]
        public void DiffTest(int x,int y,int expectedValue)
        {
            //Arrange
            var calculator=new MathFormulas();
            //Act
            var result=calculator.Diff(x,y);
            //assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(1, 2, 4)]
        public void AddTest(int x, int y, int expectedValue)
        {
            //arrange
            var calculator = new MathFormulas();
            //act
            var result = calculator.Add(x, y);
            //assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3]{1,2,3},6)]
        [InlineData(new int[4]{1,2,4,5},12)]
        public void Sum(int[] values,int expectedValue)
        {
            //arrange
            var calculator=new MathFormulas();
            //act
            var result=calculator.Sum(values);
            //assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[4] { 1, 2, 4, 5 }, 3)]
        public void AvarageTest(int[] values, int expectedValue)
        {
            //arrange
            var calculator = new MathFormulas();
            //act
            var result = calculator.Avarage(values);
            //assert
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [MemberData(nameof(MathFormulas.Data),MemberType=typeof(MathFormulas))]
        public void Add_MemberData_Test(int x,int y,int expectedValue)
        {
            //arrange
            var calculator=new MathFormulas();
            //act
            var result=calculator.Add(x,y);
            //assert
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [ClassData(typeof(MathFormulas))]   
        public void Add_ClassData_Test(int x,int y,int expectedValue)
        {
            //arrange
            var calculator=new MathFormulas();
            //act
            var result=calculator.Add(x,y);
            //assert
            Assert.Equal(expectedValue,result);
        }
    }
}