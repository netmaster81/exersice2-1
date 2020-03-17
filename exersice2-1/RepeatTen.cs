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
        public RepeatTen()
        {

        }

        public void Main()
        {
            Console.WriteLine("This software repeat to you the text you intered ten times");
            Console.WriteLine("Please Enter Your Text");
            Text = Console.ReadLine();
            string repeat="";
            for (int i=0;i<10;i++)
            {
                repeat = repeat + (i + 1) + "." + Text + ", ";// repeat Text ten times with numbering 
            }
            repeat = repeat.Remove(repeat.Length-2);// delete the last charcter ',' 

            Console.WriteLine($" {repeat}");// print the result
            
        }
     
    }
}
