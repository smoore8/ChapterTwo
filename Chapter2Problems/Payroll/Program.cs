using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

            String name, ssn, hpr, hw;
            int hourspay, hoursworked;



            double gross, fed, state, moneyperh;



            Console.Write("Enter your name:");
            name = Console.ReadLine();


            Console.Write("Social Security number:");
            ssn = Console.ReadLine();


            Console.Write("Hourly pay rate:");
            hpr = Console.ReadLine();
            hourspay = Convert.ToInt32(hpr);

            Console.Write("Hours worked:");
            hw = Console.ReadLine();
            hoursworked = Convert.ToInt32(hw);

            // Do the calculations!!!!!!
            gross = hourspay * hoursworked;
            moneyperh = gross / hoursworked;
            fed = gross * 0.15;
            state = gross * 0.05;


            Console.Write("Payroll Summary for:");
            name = Console.ReadLine();

            Console.Write("SSN {0}:", ssn);

            Console.Write("You earned {0} at {1} per hour", gross, moneyperh);



            Console.Write("Gross pay is {0}:", gross);

            Console.Write("Federal withholding is {0}:", fed);

            Console.Write("State withholding is {0}:", state);


        }
    }
}