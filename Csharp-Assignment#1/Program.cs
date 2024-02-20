using System;

namespace Csharp_Assignment_1
{
    // This is the main class file that represents the entry point to run/launch your application.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: "); //  First ask the user to enter their age.?????? The assignment document says "ask age", I don't know why ?????
            string age = Console.ReadLine();

            // Ask the user to insert the needed patient information and blood pressures (firstName, lastName, weight, height, systolic, diastolic).
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            // Console.Write("Enter your weight (in Kg): ");
            // double weight = Convert.ToDouble(Console.ReadLine());
            double weight;
            while (true) // Continue until "break"
            {
                Console.Write("Enter your weight (in Kg): ");
                // Use TryParse method and change the string input into double "weight": OK=>true and "break", NO=>false and warning/input again
                if (double.TryParse(Console.ReadLine(), out weight))
                    break;
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Console.Write("Enter your height (in cm): ");
            // double height = Convert.ToDouble(Console.ReadLine());
            double height;
            while (true) // Continue until "break"
            {
                Console.Write("Enter your height (in cm): ");
                // Use TryParse method and change the string input into double "height": OK=>true and "break", NO=>false and warning/input again
                if (double.TryParse(Console.ReadLine(), out height))
                    break;
                Console.WriteLine("Invalid input. Please enter a number.");
            }


            // Ask the user to insert the patient blood pressures (systolic, diastolic).

            // Console.Write("Enter the SYSTOLIC mm Hg (upper number): ");
            // int systolic = Convert.ToInt32(Console.ReadLine());
            int systolic;
            while (true) // Continue until "break"
            {
                Console.Write("Enter the SYSTOLIC mm Hg (upper number): ");
                // Use TryParse method and change the string input into int "systolic": OK=>true and "break", NO=>false and warning/input again
                if (int.TryParse(Console.ReadLine(), out systolic))
                    break;
                Console.WriteLine("Invalid input. Please enter a number.");
            }

                // Console.Write("Enter the DIASTOLIC mm Hg (lower number): ");
                // int diastolic = Convert.ToInt32(Console.ReadLine());
            int diastolic;
            while (true)
            {
                Console.Write("Enter the DIASTOLIC mm Hg (lower number): ");
                // Use TryParse method and change the string input into int "diastolic": OK=>true and "break", NO=>false and warning/input again
                if (int.TryParse(Console.ReadLine(), out diastolic))
                    break;
                Console.WriteLine("Invalid input. Please enter a number.");
            }



            // Create a new patient object
            Patient patient = new Patient(firstName, lastName, weight, height);
            // Print patient information
            patient.PrintPatientInfo(systolic, diastolic);
        }
    }
}
