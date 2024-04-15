namespace _28._03
{
    class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass[] myObjects = new MyClass[]
            {
            new MyClass { Id = 1, Name = "Alice", Age = 30, City = "New York", Salary = 50000 },
            new MyClass { Id = 2, Name = "Bob", Age = 35, City = "Los Angeles", Salary = 60000 },
            new MyClass { Id = 3, Name = "Charlie", Age = 25, City = "Chicago", Salary = 45000 },
            new MyClass { Id = 4, Name = "David", Age = 40, City = "Houston", Salary = 70000 },
            new MyClass { Id = 5, Name = "Eva", Age = 28, City = "Miami", Salary = 55000 }
            };
            Console.WriteLine("Original array of objects:");
            foreach (var obj in myObjects)
            {
                Console.WriteLine($"Id: {obj.Id}, Name: {obj.Name}, Age: {obj.Age}, City: {obj.City}, Salary: {obj.Salary}");
            }
            var selectedProperties = myObjects.Select(obj => new { obj.Name, obj.Age }).ToArray();
            Console.WriteLine("\nArray with selected properties (Name and Age):");
            foreach (var item in selectedProperties)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }
        }
    }
}
