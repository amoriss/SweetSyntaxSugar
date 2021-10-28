using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1. original 
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);

            //2. using inferred typing
            int inferredAnswer = 4;
            var inferredResponse = "";


            if (inferredAnswer < 9)
            {
                inferredResponse = inferredAnswer + " is less than nine";
            }
            else
            {
                inferredResponse = inferredAnswer + "greater than or equal to nine";
            }            
            Console.WriteLine(inferredResponse);


            //3. using string interpolation
            int interpAnswer = 4;            


            if (interpAnswer < 9)
            {
                Console.WriteLine($"{interpAnswer} is less than nine"); 
            }
            else
            {
                Console.WriteLine($"{interpAnswer} greater than or equal to nine"  );
            }
            
            //using ternary operator
            int ternAnswer = 4;
            var ternResponse = "";


            ternResponse = (ternAnswer < 9) ? $"{ternAnswer} is less than nine" : $"{ternAnswer} is greater than or equal to nine";

            Console.WriteLine(ternResponse);
            
        }
    }
}
