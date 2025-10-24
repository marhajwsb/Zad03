class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- HR Management System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show Employees");
            Console.WriteLine("3. Let Employees Work");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    ShowEmployees();
                    break;
                case "3":
                    DoWork();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again");
                    break;
            }
        }
    }

        static void AddEmployee()
        {
            string name;
            do
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Name cannot be empty. Please try again.");
            }
            while (string.IsNullOrWhiteSpace(name));

            int age;
            do
            {
                Console.Write("Enter age: ");
                if (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.WriteLine("Invalid age. Please enter a positive number.");
                    age = 0;
                }
            }
            while (age <= 0);

            string type;
            do
            {
                Console.WriteLine("Select employee type:");
                Console.WriteLine("1 - FullTime");
                Console.WriteLine("2 - PartTime");
                Console.WriteLine("3 - Contractor");
                Console.Write("Your choice: ");
                type = Console.ReadLine()?.Trim();

                if (type != "1" && type != "2" && type != "3")
                    Console.WriteLine("Please enter 1, 2, or 3.");
            }
            while (type != "1" && type != "2" && type != "3");

            Employee employee = type switch
            {
                "1" => new FullTimeEmployee(name, age),
                "2" => new PartTimeEmployee(name, age),
                "3" => new Contractor(name, age),
                _ => null
            };

            if (employee != null)
            {
                employees.Add(employee);
                Console.WriteLine($"{employee.Name} added as a {employee.GetType().Name}.");
            }
            else
            {
                Console.WriteLine("Invalid employee type!");
            }
        }


    static void ShowEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees in the system.");
            return;
        }

        Console.WriteLine("\nEmployee List:");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }

    static void DoWork()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees in the system.");
            return;
        }

        Console.WriteLine("\nEmployees are working:");
        foreach (var emp in employees)
        {
            emp.Work();
        }
    }
}