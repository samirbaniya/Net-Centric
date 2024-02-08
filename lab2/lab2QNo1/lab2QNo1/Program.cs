using System;

public class Employee
{
    private string firstName;
    private string lastName;
    private int salary;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Employee(string firstName, string lastName, int salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

    public void ShowFullName()
    {
        Console.WriteLine($"Full Name: {firstName} {lastName}");
    }

    public void IncrementSalary(int s)
    {
        salary += s;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Ram", "Bahadur", 20000);
        emp.ShowFullName();
        Console.WriteLine($"Salary: {emp.Salary}");


        emp.FirstName = "Hari";
        emp.LastName = "Bahadur";
        emp.IncrementSalary(5000);

        emp.ShowFullName();
        Console.WriteLine($"Salary: {emp.Salary}");

        Console.ReadLine();
    }
}