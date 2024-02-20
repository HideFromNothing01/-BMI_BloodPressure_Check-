using System;

namespace Csharp_Assignment_1
{
    // This class represents a patient with properties for their first name, last name, weight, and height.
    public class Patient
    {
        // Properties for patient's information
        public string FirstName { get; set; } // Patient's first name
        public string LastName { get; set; } // Patient's last name
        public double Weight { get; set; } // Patient's weight in Kilograms
        public double Height { get; set; } // Patient's height in Centimetres

        // Custom constructor that accepts the first name, last name, weight, and height
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // Method to calculate blood pressure
        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            // Blood pressure ranges based on the given criteria
            if (systolic < diastolic)
                return "Systolic shoud be higher than diastolic. Try it again!";
            else if (systolic < 120 && diastolic < 80)
                return "Normal";
            else if (systolic > 180 || diastolic > 120)
                return "Hypertensive Crisis (Consult your doctor immediately)";
            else if (systolic >= 140 || diastolic >= 90)
                return "High Blood Pressure (Hypertension) Stage 2";
            else if (systolic >= 130 || diastolic >= 80)
                return "High Blood Pressure (Hypertension) Stage 1";
            else if (systolic >= 120 && diastolic < 80)
                return "Elevated";
            else
                return "Invalid Number";
        }

        // Method to calculate BMI
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Convert height from cm to m
            return Weight / (heightInMeters * heightInMeters); // Return BMI formula result
        }

        // Method to print patient information
        public void PrintPatientInfo(int systolic, int diastolic)
        {
            double bmi = CalculateBMI();
            string bmiStatus = bmi >= 25 ? "Overweight" : (bmi >= 18.5 && bmi < 25) ? "Normal (In the healthy range)" : "Underweight";

            Console.WriteLine($"\nFull Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}");
            Console.WriteLine($"BMI: {bmi}");
            Console.WriteLine($"BMI Status: {bmiStatus}");

            //  Use "Console.ReadLine" to keep the console window open
            Console.WriteLine("\nPress enter key to exit...");
            Console.ReadLine();
        }
    }
}
