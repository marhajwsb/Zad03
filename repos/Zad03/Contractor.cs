class Contractor : Employee
{
    public Contractor(string name, int age) : base(name, age) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is completing tasks under a contract.");
    }
}