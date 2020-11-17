using System;

namespace _31.fibonacciNumbValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()); //n number of the Members in the row ? //we look the value of the enterd numberMember in Fibonacci

            int zeroNumber = 0; //zeroNumber = Base number to creat the second number; (ZeroNum + first number = second number int the row)
            int firstNumber = 1; //first number from the row ; to create the secound numebr in the row;
            int currentNumber = 0; //value here We dont know it still, in the cycle we will reinitialize it;(we sum the value of Zero and first always
            int totalSum = 0;

            if (n <= 1 && n > 0 )
            {
               // Console.WriteLine(1); //the first number in Fibonacci row is 1;
                Console.WriteLine("the value of the first MemberNumber in Fibonacci's row is 1");
               // firstNumber = 1; //this is first number into the row ;
                totalSum += firstNumber;
            }
            else if( n >= 2)
            {
                totalSum = firstNumber;
                for (int i = 2; i <= n ; i++)
                {
                    currentNumber = zeroNumber + firstNumber; //We always have to have value of base number(zeroNumber actualized) 
                                                             //and the firstNumber=(previous) value actialized in order to produce the next -search number in the row   :
                    totalSum = totalSum + currentNumber;
                    //Console.WriteLine($" the value of the {n}number is :{secondNumber}");
                    zeroNumber = firstNumber;  //We actualize the /zeroNumber;
                    firstNumber = currentNumber;//We actualize the firstNumber; so : zeroNumber + firstNumber =(the newSearched Number!);
                    //totalSum = totalSum + secondNumber;

                }
                Console.WriteLine($" the value of the {n}th MemberNumber FibonacciRow is :{currentNumber}");
                //Console.WriteLine(totalSum);
            }
            Console.WriteLine($"The total sum of All {n} Row_members is  = {totalSum }");
           
        }
    }
}
