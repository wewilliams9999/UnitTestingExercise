using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Right-click on Dependencies in your .Tests project and set your reference - DONE

        // Create an Add method that passes 3 integers - DONE
        public int Add (int one, int two, int three)
        {
            return one + two + three;
        }

        // Create a Subtract method that passes 2 integers  - DONE
        // Keep track of which number is getting passed as minuend and subtrahend  - DONE
        public int Subtract (int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers  - DONE
        public int Multiply (int first, int second)
        {
            return first * second;
        }

        // Create a Divide method that passes 2 integers  - DONE
        public int Divide (int dividend, int divisor)
        {
            return dividend / divisor;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public char OutputH()
        {
            return 'h';
        }

        public string HowAreYou()
        {
            return "How are you?";
        }

        
    }
}
