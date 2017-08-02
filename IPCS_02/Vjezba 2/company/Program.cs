using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Customers: ");
		foreach(string customers in Customers.allCustomers)
			Console.WriteLine(customers);
		
		Console.WriteLine("Employees: ");
		foreach(string employee in Employees.allEmployees)
			Console.WriteLine(employee);
	}
	
}