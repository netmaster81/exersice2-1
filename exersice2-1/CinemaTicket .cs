using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice2_1
{
    public class CinemaTicket
    {
        private int Und20 = 80;
        private int Over64 = 90;
        private int StanderPrice = 120;
        private int NumberOfAttend;
        private List<int> Ages;
        public CinemaTicket()
        {
            Ages = new List<int>(NumberOfAttend);
        }

        private int TicketPrice(int age)// return the value of ticket depending on age
        {
            if (age<5 || age>100)// free ticket for those ages
            {
                return 0;
            }
            if(age >=5 && age<20)
            { 
                return 80;
            }
            if (age >= 20 && age < 64)
            {
                return 120;
            }
            else return 90;
            
        }
        private int TotalPrice()// return the total price of tickets
        {
            int sum=0;
            for (int i=0;i<NumberOfAttend;i++)
            {
                sum += TicketPrice(Ages[i]);
            }
            return sum;
        }

        public void Main()// task view and working result
        {
            Console.WriteLine("this program get the number of Cinema attend  ");
            Console.WriteLine("and show you the individual price for each person depending on age  ");
            Console.WriteLine("age (<5 || >100) free, (<20) 80 Kr, (20--64) 120 Kr, (<64) 90 Kr  ");
            Console.WriteLine("and finally print to you number of attend and total price  ");
            Console.WriteLine("Please Enter the number of total attendes ");
            string input = Console.ReadLine();
            int toint;
            while(!int.TryParse(input, out toint))
            {
                Console.WriteLine("Enter a valid number:");
                input = Console.ReadLine();
            }
            NumberOfAttend = toint;
            
            for (int i=0;i<NumberOfAttend;i++)
            {
                Console.WriteLine($"Enter the age of {i + 1} person");// auto print the number of person
                input = Console.ReadLine();

                while (!int.TryParse(input, out toint))// verify the input 
                {
                    Console.WriteLine("Enter a valid number:");
                    input = Console.ReadLine();
                }

                Ages.Add(toint);// fill the Ages with values
                Console.WriteLine($"the price of ticket is : {TicketPrice(toint)} Kr");
            }
            // Final Results
            Console.WriteLine($"the total number of attendes is :{NumberOfAttend}");
            Console.WriteLine($"the total tickets cost is :{TotalPrice()} Kr");

        }

    }
}
