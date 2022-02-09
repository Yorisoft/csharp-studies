using System;
using CSharpTutorials;
using Xunit;

namespace CSharpTDD
{
    public class Conditionsals_CSharpTDD
    {

        CSharp_7 MyObject = new CSharp_7();

        // if else w. defautl
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void useConditionsal_Default_UsesIfElseWithTrueFalseCondition(bool isBool)
        {
            // ARRANGE
            bool expected = isBool,
                result;

            // ACT
            result = this.MyObject.useConditionsal(isBool);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. == condition
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void useConditionsalIsEqualsTo_BoolIsEquals_UsesIfElseWithIsEqualsToCondition(byte num1, byte num2)
        {
            // ARRANGE
            bool expected = num1 == num2,
                result;

            // ACT
            result = this.MyObject.useConditionsalIsEqualsTo(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. != condition
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void useConditionsalNotEqualsTo_BoolIsEquals_UsesIfElseWithIsEquaNotEqualsTo(byte num1, byte num2)
        {
            // ARRANGE
            bool expected = num1 != num2,
                result;

            // ACT
            result = this.MyObject.useConditionsalNotEqualsTo(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. >= condition
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void useConditionsalGreaterThanOrEqualsTo_ByteNum1ByteNum2_UsesIfElseWithIsEquaGreaterThanOrEqualsTo(byte num1, byte num2)
        {
            // ARRANGE
            bool expected = num1 >= num2,
                result;

            // ACT
            result = this.MyObject.useConditionsalGreaterThanOrEqualsTo(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. <= condition
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void useConditionsalLessThanOrEqualsTo_ByteNum1ByteNum2_UsesIfElseWithIsEquaLessThanOrEqualsTo(byte num1, byte num2)
        {
            // ARRANGE
            bool expected = num1 <= num2,
                result;

            // ACT
            result = this.MyObject.useConditionsalLessThanOrEqualsTo(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. && condition
        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        public void useConditionsalAnd_ByteNum1ByteNum2_UsesIfElseWithAnd(byte num1, byte num2, bool my_bool)
        {
            // ARRANGE
            bool expected = my_bool,
                result;

            // ACT
            result = this.MyObject.useConditionsalAnd(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }

        // if else w. || condition
        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        public void useConditionsalAOr_ByteNum1ByteNum2_UsesIfElseWithOr(byte num1, byte num2, bool my_bool)
        {
            // ARRANGE
            bool expected = my_bool,
                result;

            // ACT
            result = this.MyObject.useConditionsalAOr(num1, num2);

            // ASSERT
            Assert.Equal(expected, result);
        }
    }

    public class TernaryOperator_CSharpTDD
    {
        CSharp_8 MyObject = new CSharp_8();

        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(0, 1, false)]
        [InlineData(0, 0, true)]
        public void useTernaryOperator_ByteNum1ByteNum2_UsesTernaryOperatorToCompareNum1Num2AndReturnsBool(byte num1, byte num2, bool expect)
        {
            // ARRANGE
            bool expected = expect,
                result;

            // ACT
            result = this.MyObject.useTernaryOperator(num1, num2);

            // ASSERT
            Assert.IsType<bool>(result);
            Assert.Equal(expected, result);
        }
    }

}
