using System;

namespace CSharpTutorials
{
    public class CSharp1_3
    {
        public CSharp1_3()
        {
        }
         
        public String greetings()
        {
            return "Hello World!";
        }

        public String greetings(String name)
        {
            return $"Hello {name}!";
        }

        public byte makeNewByte(byte num)
        {
            byte var = num;
            return var;
        }

        public char makeNewChar(byte var)
        {
            char chr = (char)var;
            return chr;
        }

        public int makeNewInt(byte num)
        {
            int var = num;
            return var;
        }

        public float makeNewFloat(byte num)
        {
            float var = num;
            return var;
        }

        public long makeNewLong(byte num)
        {
            long var = num;
            return var;
        }

        public double makeNewDouble(byte num)
        {
            double var = num;
            return var;
        }

        public string makeNewString(byte[] var)
        {
            string str = System.Text.Encoding.ASCII.GetString(var);
            return str;
        }

        public bool makeNewBool(byte var)
        {
            bool boo = Convert.ToBoolean((int)var);
            return boo;
        }

        //~CSharp()
        //{
        //}
    }

    public class CSharp_4
    {
        public CSharp_4(){ }

        public int addNum(int a, int b)
        {
            return a + b;
        }

        public int subtractNum(int a, int b)
        {
            return a - b;
        }

        public int multiplyNum(int a, int b)
        {
            return a * b;
        }

        public int divideNum(int a, int b)
        {
            return a / b;
        }

        public int getRemainder(int a, int b)
        {
            return a % b;
        }

        public int orderOfPrecedence(int num1, int num2, int num3, int num4, int num5)
        {
            return (num1 + (num2 - num3) * num4) / num5;
        }

        public int incrementNum(int num)
        {
            return num + 1;
        }

        public int decrementNum(int num)
        {
            return num - 1;
        }

        ~CSharp_4() { }
    }

    public class CSharp_5
    { 
        public CSharp_5() 
        { 
        }

        public int[] createNewArray()
        {
            return new int[1];
        }

        public int[] createArraySizeN(int n)
        {
            int[] int_array = new int[n];
            return int_array;
        }

        public int[] createArrayWithElements(int elmnt1, int elmnt2, int elmnt3, int elmnt4)
        {
            int[] int_array = { elmnt1, elmnt2, elmnt3, elmnt4};
            return int_array;
        }

        ~CSharp_5()
        {
        }
    }

    public class CSharp_7
    {
        public CSharp_7() 
        { 
        }

        // if else w. defautl
        public bool useConditionsal(bool isBool) 
        {
            if (isBool)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        // if else w. == condition
        public bool useConditionsalIsEqualsTo(byte num1, byte num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if else w. != condition
        public bool useConditionsalNotEqualsTo(byte num1, byte num2)
        {
            if (num1 != num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if else w. >= condition
        public bool useConditionsalGreaterThanOrEqualsTo(byte num1, byte num2)
        {
            if (num1 >= num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if else w. <= condition
        public bool useConditionsalLessThanOrEqualsTo(byte num1, byte num2)
        {
            if (num1 <= num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if else w. && condition
        public bool useConditionsalAnd(byte num1, byte num2)
        {
            if (num1 == num2 && num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if else w. || condition
        public bool useConditionsalAOr(byte num1, byte num2)
        {
            if (num1 == num2 || num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ~CSharp_7() 
        { 
        }
    }

    public class CSharp_8
    {
        public CSharp_8()
        {
        }

        public bool useTernaryOperator(byte num1, byte num2)
        {

            return (num1 == num2) ? true : false;
        }

        ~CSharp_8()
        {
        }
    }

    public class CSharp_9
    {
        public CSharp_9()
        {
        }

        public string useSwitchStatement(byte condition)
        {
            string result;

            switch (condition) {
                case 0:
                    result = "SwitchCase Number 1";
                    break;
                case 1:
                    result = "SwitchCase Number 2";
                    break;
                case 2:
                    result = "SwitchCase Number 3";
                    break;
                default: result = "SwitchCase Not Found";
                    break;
            }

            return result;
        }

        ~CSharp_9()
        {
        }
    }


 }

//public void newFunction(byte var)
//{
//  return new byte();
//}