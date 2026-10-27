namespace Decompositioning;

public class Exercise_7 : Exercise
{
    protected override void Demonstrate()
    {
        PayrollProcessor.ProcessFreelancer("Gideon", 16.51m, 28);
        PayrollProcessor.ProcessFullTimeEmployee("Gideon", 2850, 85, false);
        PayrollProcessor.ProcessFullTimeEmployee("Gideon", 2850, 85, true);
    }
}

public class PayrollProcessor
{
    private const int RegularMonthlyHours = 160;
    private const decimal OvertimeMultiplier = 1.5m;
    private const decimal MonthlyInsuranceCost = 125m;
    
    public static void ProcessFullTimeEmployee(string name, decimal monthlySalary, int performanceScore, bool hasHealthInsurance)
    {
        if (HasValidationError(string.IsNullOrWhiteSpace(name), "Invalid employee name.") ||
            HasValidationError(monthlySalary <= 0, "Invalid salary.") ||
            HasValidationError(performanceScore is < 0 or > 100, "Invalid performance score."))
        { 
            return;
        }

        decimal bonus = CalculateBonus(monthlySalary,  performanceScore);
        decimal grossPay = monthlySalary + bonus;
        decimal tax = CalculateTax(grossPay);

        decimal insuranceCost = 0;
        
        if (hasHealthInsurance)
            insuranceCost = MonthlyInsuranceCost;

        PrintPayroll(name, grossPay, tax, "Full-time", insuranceCost);
    }

    public static void ProcessFreelancer(string name, decimal hourlyRate, int hoursWorked)
    {
        if (HasValidationError(string.IsNullOrWhiteSpace(name), "Invalid employee name.") ||
            HasValidationError(hourlyRate <= 0, "Invalid hourly rate.") ||
            HasValidationError(hoursWorked < 0, "Invalid hours worked."))
        {
            return;
        }
        
        decimal grossPay = CalculateFreelanceGrossPay(hoursWorked, hourlyRate);
        decimal tax = CalculateTax(grossPay);

        PrintPayroll(name, grossPay, tax, "Freelancer");
    }

    private static bool HasValidationError(bool condition, string errorMessage)
    {
        if (condition)
            Console.WriteLine(errorMessage);

        return condition;
    }

    private static decimal CalculateBonus(decimal monthlySalary, int performanceScore)
    {
        return performanceScore switch
        {
            >= 90 => monthlySalary * 0.20m,
            >= 75 => monthlySalary * 0.10m,
            >= 60 => monthlySalary * 0.05m,
            _ => 0
        };
    }

    private static decimal CalculateTax(decimal grossPay)
    {
        return grossPay switch
        {
            > 5000 => grossPay * 0.30m,
            > 3000 => grossPay * 0.20m,
            _ => grossPay * 0.10m
        };
    }

    private static decimal CalculateFreelanceGrossPay(int hoursWorked, decimal hourlyRate)
    {
        if (hoursWorked > RegularMonthlyHours)
        {
            int overtimeHours = hoursWorked - RegularMonthlyHours;
            return (RegularMonthlyHours * hourlyRate) + (overtimeHours * hourlyRate * OvertimeMultiplier);
        }
        
        return hoursWorked * hourlyRate;
    }

    private static void PrintPayroll(string name, decimal grossPay, decimal tax, string type, decimal insuranceCost = 0)
    {
        decimal netPay = grossPay - tax - insuranceCost;
        
        Console.WriteLine($"Employee: {name}");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine($"Gross pay: {grossPay:C}");
        Console.WriteLine($"Tax: {tax:C}");
        Console.WriteLine($"Insurance: {insuranceCost:C}");
        Console.WriteLine($"Net pay: {netPay:C}");
        Console.WriteLine("--------------------");
    }
}
