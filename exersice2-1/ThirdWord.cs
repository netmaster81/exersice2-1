using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2_1
{
    public class ThirdWord
    {
        public string Text;// input Text
        public string word;
        public ThirdWord()
        {

        }
        public ThirdWord(string text)
        {
            Text = text;
        }
        public string ThirdwordF(string text)
        {
            int thirdwordindicator = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                
                if (word.Length != 0) thirdwordindicator++;
                if (thirdwordindicator == 3)
                {
                    return word;
                }
              
            }
            return "Enter Three words to Run this program";

        }

        public void Main()
        {
            Console.WriteLine("this Software retun the third word from your text");
            Console.WriteLine("please do not Enter less than 3 words ");
            int thirdwordindicator = 0;// help me to find the third word 
            while (thirdwordindicator!=3)
            {
                string input = Console.ReadLine();
                string[] words = input.Split(' ');//split the input
                foreach (string word in words)
                {
                    //search for the non space character and print the third one
                    //whatever how many spaces it has
                    if (word.Length!=0)thirdwordindicator++;
                    if (thirdwordindicator == 3)
                    {
                        Console.WriteLine($"the third word is '{word}' ");
                        break;
                    }
                }
                //when you write just two words or less 
                if (thirdwordindicator < 3)
                {
                    Console.WriteLine("Please Enter at least three words");
                    thirdwordindicator = 0;
                }
            }

            


        }
    }
}
