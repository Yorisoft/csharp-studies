using CSharpTutorials;
using System;
using System.Text;
using Xunit;

namespace CSharpTDD
{
    public class Beginning_CSharpTDD
    {
        private CSharp1_3 MyObject;

        [Fact]
        public void CSharpConstructor_Default_ReturnsObject()
        {
            // ARRANGE
            this.MyObject = null;

            // ACT
            this.MyObject = new CSharp1_3();

            // ASSERT
            Assert.IsType<CSharp1_3>(this.MyObject);

        }

        [Fact]
        public void CSharpDestructor_AssertGCForObject()
        {
            // ARRANGE
            this.MyObject = null;
            long start_memory_allocated, end_memory_allocated;
            // ACT
            this.MyObject = new CSharp1_3();
            start_memory_allocated = GC.GetTotalMemory(false);
            Console.WriteLine(start_memory_allocated);

            this.MyObject = null;
            //GC.Collect(0);
            end_memory_allocated = GC.GetTotalMemory(true);
            Console.WriteLine(end_memory_allocated);
            Console.WriteLine(end_memory_allocated - start_memory_allocated);

            // ASSERT
            Assert.NotEqual(start_memory_allocated, end_memory_allocated);

        }

        [Fact]
        public void greetings_Default_ReturnStringGreeting()
        {
            // ARRANGE
            this.MyObject = null;
            String result, expected = "Hello World!";

            // ACT
            this.MyObject = new CSharp1_3();
            result = this.MyObject.greetings();

            // ASSERT
            Assert.Matches(expected, result);

        }

        [Theory]
        [InlineData("Yelsin")]
        [InlineData("Jessy")]
        [InlineData("Yorisoft")]
        public void greetings_StringName_ReturnStringGreetingWithName(String name)
        {
            // ARRANGE
            this.MyObject = null;
            String result, expected = $"Hello {name}!";

            // ACT
            this.MyObject = new CSharp1_3();
            result = this.MyObject.greetings(name);

            // ASSERT
            Assert.Matches(expected, result);

        }
    }

    public class Variables_CSharpTDD
    {
        private CSharp1_3 MyObject = new CSharp1_3();

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewByte_ByteNum_CreatesNewByte(byte var)
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            byte result;

            // ACT
            result = this.MyObject.makeNewByte(var);

            // ASSERT
            Assert.IsType<byte>(this.MyObject.makeNewByte(var));    // Type Check
            Assert.Equal(var, result);                              // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewInt_ByteNum_CreatesNewInt(byte var)
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            int result;

            // ACT
            result = this.MyObject.makeNewInt(var);

            // ASSERT
            Assert.IsType<int>(this.MyObject.makeNewInt(var));      // Type Check
            Assert.Equal(var, result);                              // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewFloat_ByteNum_CreatesNewFloat(byte var)
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            float result;

            // ACT
            result = this.MyObject.makeNewFloat(var);

            // ASSERT
            Assert.IsType<float>(this.MyObject.makeNewFloat(var));   // Type Check
            Assert.Equal(var, result);                               // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewLong_ByteNum_CreatesNewLong(byte var)
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            long result;

            // ACT
            result = this.MyObject.makeNewLong(var);

            // ASSERT
            Assert.IsType<long>(this.MyObject.makeNewLong(var));    // Type Check
            Assert.Equal(var, result);                              // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewDouble_ByteNum_CreatesNewDouble(byte var)
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            double result;

            // ACT
            result = this.MyObject.makeNewDouble(var);

            // ASSERT
            Assert.IsType<double>(this.MyObject.makeNewDouble(var));  // Type Check
            Assert.Equal(var, result);                                // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void makeNewChar_ByteVar_CreatesNewChar(byte var)
        {

            // ARRANGE
            //this.MyObject = new CSharp();
            string result = "", var_to_string = "";

            // ACT              Using string. Hard to check wtih char values
            result = result + this.MyObject.makeNewChar(var);
            //Console.WriteLine("result: " + result);
            var_to_string = var_to_string + (char)var;
            //Console.WriteLine("var_to_string: " + var_to_string);

            // ASSERT
            Assert.IsType<char>(this.MyObject.makeNewChar(var));                        // Type Check
            Assert.Equal(var_to_string, result);                                        // Value Check
        }

        [Theory]
        [InlineData("Foo")]
        [InlineData("Bar")]
        [InlineData("Yelsin")]
        public void makeNewString_ByteArrayVar_CreatesNewString(string var) //TODO: Use byte array to test string
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            string result;
            byte[] var_to_bytes_array = Encoding.ASCII.GetBytes(var);

            // ACT        
            result = this.MyObject.makeNewString(var_to_bytes_array);

            // ASSERT
            Assert.IsType<string>(this.MyObject.makeNewString(var_to_bytes_array));    // Type Check
            Assert.Equal(var, result);                                                 // Value Check
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void makeNewBool_ByteArrayVar_CreatesNewString(byte var) 
        {
            // ARRANGE
            //this.MyObject = new CSharp();
            bool result, expected;

            // ACT        
            result = this.MyObject.makeNewBool(var);
            expected = Convert.ToBoolean(var);

            // ASSERT
            Assert.IsType<bool>(this.MyObject.makeNewBool(var));         // Type Check
            Assert.StrictEqual<bool>(expected, result);                  // Value Check
        }
    }
}
