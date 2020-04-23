using System;

namespace TipCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your bill amount: ");
            double billAmount = GetBillAmount();
            PrintMenu();
            double tipPercent = GetTipPercent();
            CalculateTip(billAmount, tipPercent);
            Console.WriteLine("Thanks for using the Tip Calculator!");
        }

        static double GetBillAmount()
        {
            double billAmount = -1;
            while (billAmount <= 0)
            {
                try
                {
                    billAmount = double.Parse(Console.ReadLine());
                    if (billAmount < 0)
                    {
                        Console.WriteLine("Please enter a POSITIVE number: ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a number. Please enter your bill amount: ");
                }
            }
            return billAmount;
        }

        static void PrintMenu()
        {
            Console.WriteLine("How was your experience?");
            Console.WriteLine(" 1. Horrible");
            Console.WriteLine(" 2. Poor");
            Console.WriteLine(" 3. Okay");
            Console.WriteLine(" 4. Good");
            Console.WriteLine(" 5. Excellent");
            Console.Write("Choice: ");
        }

        static double GetTipPercent()
        {
            int choice;
            double tipPercent = 0;

            while (tipPercent == 0)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        tipPercent = 0.05;
                    }
                    else if (choice == 2)
                    {
                        tipPercent = 0.10;
                    }
                    else if (choice == 3)
                    {
                        tipPercent = 0.15;
                    }
                    else if (choice == 4)
                    {
                        tipPercent = 0.20;
                    }
                    else if (choice == 5)
                    {
                        tipPercent = 0.25;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("That's not a choice. Please enter your choice: ");
                    Console.WriteLine(fe.Message);
                }
            }
            return tipPercent;
        }

        static void CalculateTip(double billAmount, double tipPercent)
        {
            double totalTip = billAmount * tipPercent;
            Console.WriteLine($"The tip amount is: ${totalTip}");
            Console.WriteLine($"Your bill amount with tip totals to: ${totalTip + billAmount}");
        }
    }
}
