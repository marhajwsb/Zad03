class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name, int age) : base(name, age) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working full-time.");
    }
}