using System;

namespace TipCalculator
{
    class MainClass
    {
        //This a Gratuity calculator algorithm. The purpose of this program is to help the user determine the
        //appropriate tip amount to leave their service worker. The GratuityAcuity algorithm has the following functions:

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your bill amount: "); //Asks the user for their bill amount
            double billAmount = GetBillAmount(); //Turns the user input into a double called billAmount
            PrintMenu();  //Prints a the menu that rates their experience
            double tipPercent = GetTipPercent(); //Turns the chosen tip percent into a double called tipPercent
            CalculateTip(billAmount, tipPercent);   //this calculates the tip amount and prints off the tip and total bill amount
            Console.WriteLine("Thanks for using the Tip Calculator!");
        }

        static double GetBillAmount()  //Turns the user input into a double called billAmount
        {
            double billAmount = -1;
            while (billAmount <= 0)
            {
                try
                {
                    billAmount = double.Parse(Console.ReadLine());
                    if (billAmount < 0)   //if the user enters a negative amount, the compiler prints off an error message
                    {
                        Console.WriteLine("Please enter a POSITIVE number: ");
                    }
                }
                catch (FormatException)  //if the user does not enter a number, the compiler prints off an error message
                {
                    Console.WriteLine("That's not a number. Please enter your bill amount: ");
                }
            }
            return billAmount;  //the billAmount is returned to Main
        }

        static void PrintMenu()  //Prints a the menu that rates their experience
        {
            Console.WriteLine("How was your experience?");
            Console.WriteLine(" 1. Horrible");
            Console.WriteLine(" 2. Poor");
            Console.WriteLine(" 3. Okay");
            Console.WriteLine(" 4. Good");
            Console.WriteLine(" 5. Excellent");
            Console.Write("Choice: ");
        }

        static double GetTipPercent()  //Turns the user choice from PrintMenu into a double called tipPercent
        {
            int choice;
            double tipPercent = 0;

            while (tipPercent == 0)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)        //The tipPercent if user had a horrible experience
                    {
                        tipPercent = 0.05;
                    }
                    else if (choice == 2)   //The tipPercent if user had a poor experience
                    {
                        tipPercent = 0.10;
                    }
                    else if (choice == 3)   //The tipPercent if user had a okay experience
                    {
                        tipPercent = 0.15;
                    }
                    else if (choice == 4)   //The tipPercent if user had a good experience
                    {
                        tipPercent = 0.20;
                    }
                    else if (choice == 5)   //The tipPercent if user had a excellent experience
                    {
                        tipPercent = 0.25;
                    }
                }
                catch (FormatException fe)  //The catch handler for when the user did not enter a choice listed in the PrintMenu()
                {
                    Console.WriteLine("That's not a choice. Please enter your choice: ");
                    Console.WriteLine(fe.Message);
                }
            }
            return tipPercent; //the tipPercent is returned to Main
        }

        static void CalculateTip(double billAmount, double tipPercent) //Calculates the tip amount and prints off the tip and total bill amount
        {
            double totalTip = billAmount * tipPercent;  //Calculates the tip amount as totalTip
            Console.WriteLine($"The tip amount is: ${totalTip}");
            Console.WriteLine($"Your bill amount with tip totals to: ${totalTip + billAmount}");
        }
    }
}
