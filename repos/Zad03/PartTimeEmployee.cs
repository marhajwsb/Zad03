class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name, int age) : base(name, age) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working part-time.");
    }
}