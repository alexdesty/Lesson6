namespace Lesson6;
internal class Manager : EmployeeBase
{
    public override string Name { get; set; }
    public override string Position { get; set; }

    public string Department { get; set; }

    public override void GetDetails()
    {
        Console.WriteLine($"List of managers\nManager's name: {Name}\nManager's position: {Position}\nManager's department:{Department}\n");
    }
}

