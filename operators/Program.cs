//ternary operator
//using System;

//namespace Operator
//{
//    class TernaryOperator
//    {
//        public static void Main(string[] args)
//        {
//            int number = 10;
//            string result;

//            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
//            Console.WriteLine("{0} is {1}", number, result);
//        }
//    }
//}



////logical operator

//using System;

//namespace Operator
//{
//    class LogicalOperator
//    {
//        public static void Main(string[] args)
//        {
//            bool result;
//            int firstNumber = 10, secondNumber = 20;

//            // OR operator
//            result = (firstNumber == secondNumber) || (firstNumber > 5);
//            Console.WriteLine(result);

//            // AND operator
//            result = (firstNumber == secondNumber) && (firstNumber > 5);
//            Console.WriteLine(result);
//        }
//    }
//}


////comparision operator

//using System;

//namespace Operator
//{
//    class RelationalOperator
//    {
//        public static void Main(string[] args)
//        {
//            bool result;
//            int a = 10, b = 20;

//            result = (a == b);
//            Console.WriteLine("{0} == {1} returns {2}", a,b,result);
//        }
//    }
//}


////Arithmeticoperator
using System;

namespace Operator
{
    class ArithmeticOperator
    {
        public static void Main()
        {
            int firstNumber, secondNumber, result;
            firstNumber = 10;
            secondNumber = 20;
            result = firstNumber + secondNumber;
            Console.WriteLine("The total Value:" + result);

        }
    }
}

////Assingment operator
//using System;

//namespace Operator
//{
//    class AssignmentOperator
//    {
//        public static void Main()
//        {
//            int firstNumber;
//            firstNumber = 10;
//            Console.WriteLine("First Number = {0}", firstNumber);

//        }

//    }
//}