using exceptionDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        ExceptionExa example = new ExceptionExa();

        example.DivideByZero();

        example.NullReferenceExcep();

        // check valid age 

        try
        {
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            example.ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(ArgumentOutOfRangeException ex) {
            Console.WriteLine(ex.Message);
        }

        //insufficient fund custom exception

        BankAccount bankAccount = new BankAccount(3000);

        try
        {
            Console.WriteLine("Enter amount to withdraw :");
            double amount = Convert.ToDouble(Console.ReadLine());
            bankAccount.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //handled Exception for empty list

        example.EmptyList();

        //key not found exception
        example.KeyNotFoundExep();

        //handle Argumenet null exception
        try
        {
            string msg = null;
            example.PrintMassege(msg);
        }
        catch (ArgumentNullException ex) { 
            Console.WriteLine( "error :" +ex.Message);
        }


        CustomExceptionDemo exampleDemo = new CustomExceptionDemo();
        exampleDemo.ValidateEmpId();
    }
}