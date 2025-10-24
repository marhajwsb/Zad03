abstract class Employee
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    protected Employee(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name can't be empty");
        if (age <= 0) throw new ArgumentException("Age must be > 0");
        Name = name;
        Age = age;
    }

    public abstract void Work();

    public override string ToString()
    {
        return $"{GetType().Name}: {Name}, Age: {Age}";
    }
}