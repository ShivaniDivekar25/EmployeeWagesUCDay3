namespace EmployeeWagesUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages computation program!");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            EmployeeWagesUC1.EmployeeUC1(empCheck);
        }
    }
}