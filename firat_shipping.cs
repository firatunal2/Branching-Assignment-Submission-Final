// Package Express Shipping Calculator
// Programmer: Emily Rodriguez
// Date: 2024-03-15
using System;

namespace ExpressShipping
{
    class CargoCalculator
    {
        static void Main(string[] args)
        {
            // Display program header
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            try
            {
                // Get package weight input
                Console.WriteLine("Please enter the package weight:");
                double cargoWeight = Convert.ToDouble(Console.ReadLine());

                // Validate against maximum weight limit
                if (cargoWeight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return;
                }

                // Request package dimensions
                Console.WriteLine("Please enter the package width:");
                double cargoWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double cargoHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double cargoLength = Convert.ToDouble(Console.ReadLine());

                // Calculate total package size
                double packageSize = cargoWidth + cargoHeight + cargoLength;

                // Check if package exceeds size limit
                if (packageSize > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }

                // Calculate shipping cost
                // Formula: (width * height * length * weight) / 100
                double transportCost = (cargoWidth * cargoHeight * cargoLength * cargoWeight) / 100;

                // Display final shipping cost
                Console.WriteLine($"Your estimated total for shipping this package is: ${transportCost:F2}");
                Console.WriteLine("Thank you!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
} 