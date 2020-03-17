using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2_1
{
    public class Mainmenu
    {
        public Mainmenu()
        {

        }
        public void TaskPrintMenu()
        {
            Console.WriteLine("1-Youth or senior citizen Cinema Ticket");
            Console.WriteLine("2-Repeat ten times ");
            Console.WriteLine("3-Print The third word");
            Console.WriteLine("For choosing the program Enter number of task + Enter");
            Console.WriteLine("for Exit Enter Q + Enter ");
            Console.WriteLine("For starting Enter the number of Task : ");
            
        }
        public void Menu()
        {
            bool keepgoing = true;
            

            
            while (keepgoing == true)
            {
                /*Console.WriteLine("1-Youth or senior citizen Cinema Ticket");
                Console.WriteLine("2-Repeat ten times ");
                Console.WriteLine("3-Print The third word");
                Console.WriteLine("For choosing the program Enter number of task + Enter");
                Console.WriteLine("for Exit Enter Q + Enter ");
                Console.WriteLine("For starting Enter the number of Task : ");*/
                string input = Console.ReadLine();
               
                switch (input)
                {
                    case "1":
                        CinemaTicket CT = new CinemaTicket();
                        Console.Clear();
                        CT.Main();
                        Console.WriteLine("press any key to go back to the list");
                        Console.ReadLine();
                        Console.Clear();
                        TaskPrintMenu();
                        break;
                    case "2":
                        RepeatTen RT = new RepeatTen();
                        Console.Clear();
                        RT.Main();
                        Console.WriteLine("press any key to go back to the list");
                        Console.ReadLine();
                        Console.Clear();
                        TaskPrintMenu();

                        break;
                    case "3":
                        ThirdWord TW = new ThirdWord();
                        Console.Clear();
                        TW.Main();
                        Console.WriteLine("press any key to go back to the list");
                        Console.ReadLine();
                        Console.Clear();
                        TaskPrintMenu();

                        break;
                    case "Q":
                        keepgoing = false;
                        break;
                    default:
                        Console.WriteLine("Enter a right input....Always you can quit by Q:");
                        break;



                }
            }

        }
    }
}
