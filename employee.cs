using System;

public class ArrayMin
{
    public int Min(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Dizi boş olamaz.");
        }

        int minValue = array[0];

        foreach (int value in array)
        {
            if (value < minValue)
            {
                minValue = value;
            }
        }

        return minValue;
    }

    public static void Main(string[] args)
    {
        // ArrayMin test
        Console.WriteLine("Dizinin boyutunu girin:");
        int size = int.Parse(Console.ReadLine());
        
        int[] array = new int[size];

        Console.WriteLine("Dizinin elemanlarını girin:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        ArrayMin arrayMin = new ArrayMin();
        int minValue = arrayMin.Min(array);

        Console.WriteLine("Dizideki en küçük değer: " + minValue);

        // Employee bonus test
        Employee dev = new Developer(1, "Alice", 200000);
        Employee mgr = new Manager(2, "Bob", 180000);
        Employee admin = new Admin(3, "Charlie", 100000);

        Console.WriteLine($"{dev.Name} ({dev.Position}) - Bonus: {dev.CalculateBonus()} €");
        Console.WriteLine($"{mgr.Name} ({mgr.Position}) - Bonus: {mgr.CalculateBonus()} €");
        Console.WriteLine($"{admin.Name} ({admin.Position}) - Bonus: {admin.CalculateBonus()} €");
    }
}

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, string position, decimal salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public abstract decimal CalculateBonus();
}

public class Developer : Employee
{
    public Developer(int id, string name, decimal salary)
        : base(id, name, "Developer", salary)
    {
    }

    public override decimal CalculateBonus()
    {
        decimal bonus = Math.Max(50000, Salary * 0.20M);
        return bonus;
    }
}

public class Manager : Employee
{
    public Manager(int id, string name, decimal salary)
        : base(id, name, "Manager", salary)
    {
    }

    public override decimal CalculateBonus()
    {
        decimal bonus = Math.Max(50000, Salary * 0.25M);
        return bonus;
    }
}

public class Admin : Employee
{
    public Admin(int id, string name, decimal salary)
        : base(id, name, "Admin", salary)
    {
    }

    public override decimal CalculateBonus()
    {
        return 50000;
    }
}
