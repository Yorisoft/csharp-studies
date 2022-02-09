using System;
using CSharpTutorials;
using Xunit;

namespace CSharpTDD
{
    public class Operators_CSharpTDD
    {
        private CSharp_4 MyObject = new CSharp_4();

        [Theory]
        [InlineData(1, 2)]
        [InlineData(100, 200)]
        [InlineData(3000, 2000)]
        public void addNum_IntNumIntNum_AddsTwoIntegers(int a, int b) 
        {
            // ARRANGE
            int expected = a + b,
                result;

            // ACT
            result = this.MyObject.addNum(a, b);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(200, 100)]
        [InlineData(3000, 2000)]
        public void subtractNum_IntNumIntNum_SubtractTwoIntegers(int a, int b)
        {
            // ARRANGE
            int expected = a - b,
                result;

            // ACT
            result = this.MyObject.subtractNum(a, b);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(100, 100)]
        public void multiplyNum_IntNumIntNum_MultiplyTwoIntegers(int a, int b)
        {
            // ARRANGE
            int expected = a * b,
                result;

            // ACT
            result = this.MyObject.multiplyNum(a, b);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(200, 10)]
        [InlineData(4000, 2000)]
        public void divideNum_IntNumIntNum_DivideTwoIntegers(int a, int b)
        {
            // ARRANGE
            int expected = a / b,
                result;

            // ACT
            result = this.MyObject.divideNum(a, b);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 2)]
        [InlineData(5, 2)]
        public void getRemainder_IntNumIntNum_DivideTwoIntegers(int a, int b)
        {
            // ARRANGE
            int expected = a % b,
                result;

            // ACT
            result = this.MyObject.getRemainder(a, b);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1, 3, 1, 2, 1)]
        [InlineData(2, 6, 2, 4, 2)]
        [InlineData(4, 12, 4, 8, 4)]
        public void orderOfPrecedence_IntNumIntNumIntNumIntNum_EvaluatesEquationWithMultipleOperators(int num1, int num2, int num3, int num4, int num5)
        {
            // ARRANGE
            int expected = (num1 + (num2 - num3) * num4) / num5,
                result;

            // ACT
            result = this.MyObject.orderOfPrecedence(num1, num2, num3, num4, num5);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void incrementNum_IntNum_IncrementsIntByOne(int num)
        {
            // ARRANGE
            int expected, result;

            // ACT
            expected = num + 1;
            result = this.MyObject.incrementNum(num);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void dencrementNum_IntNum_DecrementsIntByOne(int num)
        {
            // ARRANGE
            int expected, result;

            // ACT
            expected = num - 1;
            result = this.MyObject.decrementNum(num);

            // ASSERT
            Assert.Equal<int>(expected, result);

        }
    }

    public class Arrays_CSharpTDD
    {
        private CSharp_5 MyObject = new CSharp_5();
        public Arrays_CSharpTDD()
        {
        }

        [Fact]
        public void createNewArray_Default_CreateANewArray()
        {
            // ARRANGE
            int[] result;

            // ACT
            result = this.MyObject.createNewArray();

            // ASSERT
            Assert.IsType<int[]>(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void createArraySizeN_IntN_CreateANewArrayOfSizeN(int n)
        {
            // ARRANGE
            int[] expected = new int[n],
                result;

            // ACT
            result = this.MyObject.createArraySizeN(n);

            // ASSERT
            Assert.IsType<int[]>(result);
            Assert.Equal<int>(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(5, 6, 7, 8)]
        [InlineData(9, 10, 11, 12)]
        public void createArrayWithElements_IntElmnts1234_CreateANewArrayWithElmnts1234(int elmnt1, int elmnt2, int elmnt3, int elmnt4)
        {
            // ARRANGE
            int[] expected = { elmnt1, elmnt2, elmnt3, elmnt4 },
                result;

            // ACT
            result = this.MyObject.createArrayWithElements(elmnt1, elmnt2, elmnt3, elmnt4);

            // ASSERT
            Assert.IsType<int[]>(result);
            Assert.Equal<int>(expected, result);
        }


        ~Arrays_CSharpTDD()
        {
        }
    }
}
