namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // without polymorphism
            SalariedEmployee salEmp = new SalariedEmployee(101, "John", 1000);
            Console.WriteLine(salEmp);
            Console.WriteLine($"\nEarnings = {salEmp.Earnings():C}\n\n");

            HourlyEmployee hrEmp = new HourlyEmployee(102, "Anne", 50, 22);
            Console.WriteLine(hrEmp);
            Console.WriteLine($"\nEarnings = {hrEmp.Earnings():C}\n\n");

            CommissionEmployee commEmp = new CommissionEmployee(103, "Mark", 10000, 0.12);
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings = {commEmp.Earnings():C}\n\n");


            // with polymorphism
            Employee emp;

            emp = new SalariedEmployee(101, "John", 1000);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");

            emp = new HourlyEmployee(102, "Anne", 50, 22);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");

            emp = new CommissionEmployee(103, "Mark", 10000, 0.12);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");
        }
    }
}
