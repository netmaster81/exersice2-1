using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2_1
{
    public class RepeatTen
    {
        private string Text;// input Text
        public string TenTimesText;// for Testing issues
        public RepeatTen()
        {

        }
        public RepeatTen(string text)// for testing
        {
            Text = text;

            for (int i = 0; i < 10; i++)
            {
                TenTimesText = TenTimesText + (i + 1) + "." + Text + ", ";// repeat Text ten times with numbering 
            }
            TenTimesText = TenTimesText.Remove(TenTimesText.Length - 2);// delete the last charcter ',' 
        }
        

        public void Main()
        {
            Console.WriteLine("This software repeat to you the text you intered ten times");
            Console.WriteLine("Please Enter Your Text");
            Text = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                TenTimesText = TenTimesText + (i + 1) + "." + Text + ", ";// repeat Text ten times with numbering 
            }
            TenTimesText = TenTimesText.Remove(TenTimesText.Length-2);// delete the last charcter ',' 

            Console.WriteLine($" {TenTimesText}");// print the result
            
        }
     
    }
}
