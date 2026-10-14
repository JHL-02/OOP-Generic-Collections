namespace OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALL EMPLOYEES
            var employee1 = new Employee(1001, "Kiara", Gender.Female, 53885.45m);
            var employee2 = new Employee(1002, "Kai", Gender.Male, 57673.15m);
            var employee3 = new Employee(1003, "Niko", Gender.Male, 50711.95m);
            var employee4 = new Employee(1004, "Ivy", Gender.Female, 62209.00m);
            var employee5 = new Employee(1005, "Astrid", Gender.Female, 52656.75m);
            #endregion

            #region PART 1
            //ADDING EMPLOYEES TO STACK
            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            //PRINTING OUT ALL EMPLOYEES
            Console.WriteLine("Printing");
            foreach (var e in employees)
            {
                Console.WriteLine(e);
                Console.WriteLine($"(There are {employees.Count} employees)");
            }

            Console.WriteLine();

            //TEMP LIST FOR EMPLOYEES
            List<Employee> tempList = new List<Employee>();

            //POP-METHOD
            Console.WriteLine("Popping");
            do
            {
                Console.WriteLine(employees.Peek());
                tempList.Add(employees.Pop());
                Console.WriteLine($"(There are {employees.Count} employees left)");
            }
            while (employees.Count > 0);

            //PUSHING BACK
            foreach (var employee in tempList)
            {
                employees.Push(employee);
            }

            Console.WriteLine();

            //FIRST PEEK
            Console.WriteLine("Peeking twice");
            Console.WriteLine(employees.Peek());
            Console.WriteLine($"There are {employees.Count} employees left");

            //SECOND PEEK
            Console.WriteLine(employees.Peek());
            Console.WriteLine($"There are {employees.Count} employees left");

            Console.WriteLine();

            //CONTAINS
            bool exists = employees.Contains(employee3);
            Console.WriteLine("Checking if Employee3 exists");
            if (exists)
            {
                Console.WriteLine("Yes, it does");
            }
            else
            {
                Console.WriteLine("No...");
            }
            #endregion

            Console.WriteLine("\nPress any key to continue to part 2");
            Console.ReadKey();
            Console.Clear();

            #region PART 2
            List<Employee> newEmployees = new List<Employee>();
            newEmployees.Add(employee1);
            newEmployees.Add(employee2);
            newEmployees.Add(employee3);
            newEmployees.Add(employee4);
            newEmployees.Add(employee5);

            //CONTAINS
            if (newEmployees.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine();

            //FIND FIRST
            Employee firstMale = newEmployees.Find(e => e.Gender == Gender.Male);
            Console.WriteLine("The first male employee is:");
            Console.WriteLine(firstMale);

            Console.WriteLine();

            //FIND ALL
            List<Employee> allMales = newEmployees.FindAll(e => e.Gender == Gender.Male);
            Console.WriteLine("All the male employees are:");
            foreach (var all in allMales)
            {
                Console.WriteLine(all);
            }
            #endregion
        }
    }
}
