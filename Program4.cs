using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char rightBracket = '(';
            char leftBracket = ')';          
            int rightBracketCount = 0;
            int leftBracketCount = 0;
            bool areRightBracketFirst;
            bool isBracketEqual;
          
            Console.WriteLine("Ведитие строку из символов '{0}' и '{1}'", rightBracket, leftBracket)  ;
            userInput = Console.ReadLine();

            foreach (var text1 in userInput)
            {
                if (text1 == rightBracket)
                {
                    rightBracketCount++;

                }
                else if (text1 == leftBracket)
                {
                    leftBracketCount++;
                }
            }

            areRightBracketFirst = userInput[0] == rightBracket;
            isBracketEqual = rightBracketCount == leftBracketCount;   
            
      
            if (areRightBracketFirst && isBracketEqual)
            {
               Console.WriteLine ("Строка корректная и максимум глубины равняется " + rightBracketCount); 
            }
            else
            {
                Console.WriteLine("Строка НЕкорректная");
            }
        }
    }
}
