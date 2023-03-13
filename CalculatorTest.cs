using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTutorialYouTube
{
    public class CalculatorTest
    {
        private readonly Calculator _sut;

        public CalculatorTest()
        {
            _sut = new Calculator();
        }

        [Fact]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5,5);
            
            Assert.Equal(10, _sut.Value);

        }

        [Fact]
        public void AddTwoNumbersShouldEqualTheirEqual2()
        {
            _sut.Add(5,6);
            
            Assert.Equal(11, _sut.Value);

        }

        [Theory]
        [InlineData(5,7,12)]
        [InlineData(55,75,130)]
        [InlineData(44,7,51)]
        public void AddTwoNumbersShouldEqualTheirEqualTheory(int a, int b, int expected)
        {
            _sut.Add(a,b);
            //_sut.Add(6);
            Assert.Equal(expected, _sut.Value); 

        }

        [Fact]
        public void SubstractTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Substract(5, 5);

            Assert.Equal(0, _sut.Value);

        }

        [Fact]
        public void SubstractTwoNumbersShouldEqualTheirEqual2()
        {
            _sut.Substract(55, 6);

            Assert.Equal(49, _sut.Value);

        }

        [Theory]
        [InlineData(5, 7, -2)]
        [InlineData(55, 75, -20)]
        [InlineData(44, 7, 37)]
        public void SubstractTwoNumbersShouldEqualTheirEqualTheory(int a, int b, int expected)
        {
            _sut.Substract(a, b);
            //_sut.Add(6);
            Assert.Equal(expected, _sut.Value);

        }
    }
}
