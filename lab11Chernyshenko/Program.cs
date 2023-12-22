using System;

public class Programmer
{
    public string LastName { get; set; }
    public int NumPrograms { get; set; }
    public int NumLanguages { get; set; }

    public Programmer(string lastName, int numPrograms, int numLanguages)
    {
        LastName = lastName;
        NumPrograms = numPrograms;
        NumLanguages = numLanguages;
    }

    public virtual double CalculateQuality()
    {
        return NumPrograms * NumLanguages;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Программист:");
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Количество написанных программ: {NumPrograms}");
        Console.WriteLine($"Количество написанных языков: {NumLanguages}");
        Console.WriteLine($"число программ и число языков: {CalculateQuality()}");
    }
}

public class AdvancedProgrammer : Programmer
{
    public int NumCorrectPrograms { get; set; }

    public AdvancedProgrammer(string lastName, int numPrograms, int numLanguages, int numCorrectPrograms)
        : base(lastName, numPrograms, numLanguages)
    {
        NumCorrectPrograms = numCorrectPrograms;
    }

    public override double CalculateQuality()
    {
        return base.CalculateQuality() * NumCorrectPrograms / NumPrograms;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Programmer programmer = new Programmer("Владимир", 10, 5);
        programmer.PrintInfo();

        Console.WriteLine();

        AdvancedProgrammer advancedProgrammer = new AdvancedProgrammer("Алексей", 15, 8, 12);
        advancedProgrammer.PrintInfo();
    }
}
