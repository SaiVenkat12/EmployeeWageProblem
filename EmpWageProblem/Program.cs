namespace EmpWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Employee Wage Problem---");

            Employee.computeEmpWage("Apple", 30, 20,100);
            Employee.computeEmpWage("Dmart", 10, 20, 100);


        }
    }
}