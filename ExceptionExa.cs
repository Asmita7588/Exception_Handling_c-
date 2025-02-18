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
            catch (DivideByZeroException ex)
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
            if (age < 18 && age > 0)
            {
                throw new InvalidAgeException("Provided age is less than 18. Please enter an age of 18 or above.");
            }
            if(age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative");
            }
            Console.WriteLine("Registration successful!");
        }
        
        //trying to access emptyList Elements
        public void EmptyList()
        {
            try
            {
                List<int> ints = new List<int>();

                var getInts = ints.First();

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("error, trying to access empty list element");
                Console.WriteLine(ex.Message);
            }
        }

        //key not fount exception

        public void KeyNotFoundExep()
        {
            Dictionary<string , string> dict = new Dictionary<string , string>();
            dict.Add("1", "Java");
            dict.Add("2", ".NET");
            dict.Add("3", "cSharp");

            try
            {
                Console.WriteLine("Enter key :");
                string accessKey = Console.ReadLine();

                string keyForValue = dict[accessKey];
            }catch(KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintMassege(string massege)
        {
            if (massege == null) {
                throw new ArgumentNullException("provide argument is null");
            }
            Console.WriteLine(massege);
        }
    }
}

    