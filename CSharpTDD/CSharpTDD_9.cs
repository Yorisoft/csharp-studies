using System;
using CSharpTutorials;
using Xunit;

namespace CSharpTDD
{
    public class CSharpTDD_9
    {
        CSharp_9 MyObject = new CSharp_9();

        [Theory]
        [InlineData(0, "SwitchCase Number 1")]
        [InlineData(1, "SwitchCase Number 2")]
        [InlineData(2, "SwitchCase Number 3")]
        public void useSwitchStatement_IntCondition_ReturnExpectedStringUsingSwitchStatement(byte condition, string expect) 
        {
            // ARRANGE
            string expected = expect,
                result;

            // ACT
            result = this.MyObject.useSwitchStatement(condition);

            // ASSERT
            Assert.Equal(result, expected);
        }
    }
}
