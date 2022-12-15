namespace EmployeeWagesUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 for Welcome message program\nEnter 1 for UC1\nEnter 2 for UC2\nEnter 3 for UC3\nEnter 4 for UC4\nEnter 5 for UC5\nEnter 6 for UC6");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Welcome to employee wages computation program!");
                    break;
                case 1:
                    Random random = new Random();
                    int empCheck = random.Next(0, 2);
                    EmployeeWagesUC1.EmployeeUC1(empCheck);
                    break;
                case 2:
                    Random random1 = new Random();
                    int empCheck1 = random1.Next(0, 2);
                    EmployeeWagesUC2.EmployeeUC2(empCheck1);
                    break;
                case 3:
                    Random random2 = new Random();
                    int empCheck2 = random2.Next(0, 3);
                    EmployeeWagesUC3.EmployeeUC3(empCheck2);
                    break;
                case 4:
                    Random random3 = new Random();
                    int empCheck3 = random3.Next(0, 3);
                    EmployeeWagesUC4.EmployeeUC4(empCheck3);
                    break;
                case 5:
                    Random random4 = new Random();
                    int empCheck4 = random4.Next(0, 3);
                    EmployeeWagesUC5.EmployeeUC5(empCheck4);
                    break;
                case 6:
                    Random random5 = new Random();
                    int empCheck5 = random5.Next(0, 3);
                    EmployeeWagesUC6.EmployeeUC6(empCheck5);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}