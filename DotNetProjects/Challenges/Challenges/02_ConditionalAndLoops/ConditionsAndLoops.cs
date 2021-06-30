using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_ConditionalAndLoops
{
    [TestClass]
    public class ConditionsAndLoops
    {
        //Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time. Next, do the same,
        //except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".
        //Bonus: After that, print the number of letters in the word(do this with code, not by counting manually and hard-coding the number).
        //Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'.
        [TestMethod]
        public void ConditionsandLoops(int counter)
        {
            string word = "Supercalifragilisticexpialidocious";
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            foreach (char letter in word)
            {
               counter++;
                if (letter.ToString().ToUpper() == "L")
                { 
                   Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or l");
                }
            }

            Console.WriteLine($"This word has {counter} letters in it");
            Console.WriteLine($"This word has {word.Length} letters in it");
        }
    }
}
