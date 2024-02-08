namespace LINQQuerySyntax
{
    public record Employee(string FirstName, string LastName, string Department);
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Nicholas", "Mamau", "Development"),
                new Employee("Ken", "Njuguna", "Sales"),
                new Employee("Ken", "Njenga", "Sales"),
                new Employee("Paul", "Kiprotech", "Project Management"),
                new Employee("Isaac", "Soita","Project Management"),
                new Employee("James", "Kimani", "Development")
            };

            var selectedEmployees = from employee in employees
                                    where employee.FirstName.StartsWith("J")
                                    orderby employee.LastName
                                    select employee;

            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            
        }
    }
}