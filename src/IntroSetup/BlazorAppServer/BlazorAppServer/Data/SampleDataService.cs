using BlazorAppServer.Models;

namespace BlazorAppServer.Data
{
    public static class SampleDataService
    {
        public static List<Department> GetDepartments() => new()
        {
            new Department { Id = 1, Name = "IT", Description = "Software Development" },
            new Department { Id = 2, Name = "HR", Description = "Human Resources" },
            new Department { Id = 3, Name = "Sales", Description = "Sales and Marketing" },
        };

        public static List<Product> GetProducts() => new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "14-inch Ultrabook", Price = 1200, DepartmentId = 1 },
            new Product { Id = 2, Name = "Office Chair", Description = "Ergonomic chair", Price = 150, DepartmentId = 2 },
            new Product { Id = 3, Name = "Headset", Description = "Noise-cancelling", Price = 80, DepartmentId = 3 },
        };

        public static List<Customer> GetCustomers() => new()
        {
            new Customer { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
            new Customer { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "555-123-9876" },
        };
    }
}
