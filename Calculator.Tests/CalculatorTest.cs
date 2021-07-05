using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Addition1()
        {
            double input1 = 2.0;
            double input2 = 3.0;
            double expected = 5.0;

            double result = Program.Addition(input1, input2); 

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Addition2()
        {
            double[] inputs = {1,2,3,4,5,6};
            double expected = 21;

            double result = Program.Addition(inputs);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtraction1()
        {
            double input1 = 2.0;
            double input2 = 3.0;
            double expected = -1.0;

            double result = Program.Subtraction(input1, input2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtraction2()
        {
            double[] inputs = { 1, 2, 3, 4, 5, 6 };
            double expected = -21;

            double result = Program.Subtraction(inputs);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiplication()
        {
            double input1 = 2.0;
            double input2 = 3.0;
            double expected = 6.0;

            double result = Program.Multiplication(input1, input2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Division1()
        {
            double input1 = 2.0;
            double input2 = 4.0;
            double expected = 0.5;

            double result = Program.Division(input1, input2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Division2()
        {
            double input1 = 1;
            double input2 = 0;

            double result;

            Assert.Throws<DivideByZeroException>(()=> result = Program.Division(input1, input2));
        }

        [Fact]
        public void Squareroot()
        {
            double input = 9.0;
            double expected = 3.0;

            double result = Program.Squareroot(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Power()
        {
            double input1 = 4;
            double input2 = 5;
            double expected = 1024;

            double result = Program.Power(input1, input2);

            Assert.Equal(expected, result);

        }
        
    }
}
