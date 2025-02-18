using System;

namespace exceptionDemo
{
    internal class ExceptionExa
    {
        public void DivideByZero()
        {
            try
            {
                Console.WriteLine("Enter an Integer:");
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        double result = 68 / num;
                        Console.WriteLine($"Result: {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        public void NullReferenceExcep()
        {
            try
            {
                string? str = null; // Made nullable
                if (str != null)
                {
                    Console.WriteLine($"String length: {str.Length}");
                }
                else
                {
                    Console.WriteLine("Error: String is null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Provided age is less than 18. Please enter an age of 18 or above.");
            }
            Console.WriteLine("Registration successful!");
        }
    }
}

    