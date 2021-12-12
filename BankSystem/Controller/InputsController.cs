using System;

namespace BankSystem.Controller
    {
    /// <summary>
    /// Check the inputs for double
    /// </summary>
    internal class InputsController
        {
        public static double inputDoubleControllar()
            {
            double check;
            while (!double.TryParse(Console.ReadLine(),out check))
                {
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }

        /// <summary>
        /// Check the inputs for int
        /// </summary>
        /// <returns> </returns>
        public static int inputIntControllar()
            {
            int check;
            while (!int.TryParse(Console.ReadLine(),out check))
                {
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }
        }
    }