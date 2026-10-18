namespace SeconedAssignment
{

    public abstract class Employee : IWorkable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateSalary();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }

        public abstract void work();


    }
}

