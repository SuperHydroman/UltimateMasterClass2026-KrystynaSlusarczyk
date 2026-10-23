namespace Decompositioning;

public class Exercise_7 : Exercise
{
    protected override void Demonstrate()
    {
        var application = new PayrollProcessor();
        
        application.ProcessFreelancer("Gideon", 16.51m, 28);
        Console.WriteLine("-------------------");
        application.ProcessFullTimeEmployee("Gideon", 2850, 85, false);
        Console.WriteLine("-------------------");
        application.ProcessFullTimeEmployee("Gideon", 2850, 85, true);
    }
}

public class PayrollProcessor
{
    public void ProcessFullTimeEmployee(string name, decimal monthlySalary, int performanceScore, bool hasHealthInsurance)
    {
        if (!IsValidEmployeeName(name) || !IsValidSalary(monthlySalary) || !IsValidPerformanceScore(performanceScore))
            return;

        decimal bonus = CalculateBonus(monthlySalary,  performanceScore);
        decimal grossPay = monthlySalary + bonus;
        decimal tax = CalculateTax(grossPay);

        decimal insuranceCost = 0;
        
        if (hasHealthInsurance)
            insuranceCost = 125m;

        PrintPayroll(name, grossPay, tax, insuranceCost, "Full-time");
    }

    public void ProcessFreelancer(string name, decimal hourlyRate, int hoursWorked)
    {
        if (!IsValidEmployeeName(name) || !IsValidHourlyRate(hourlyRate) || !IsValidHoursWorked(hoursWorked))
            return;

        
        decimal grossPay;

        if (hoursWorked > 160)
        {
            int overtimeHours = hoursWorked - 160;
            grossPay = (160 * hourlyRate)
                       + (overtimeHours * hourlyRate * 1.5m);
        }
        else
        {
            grossPay = hoursWorked * hourlyRate;
        }

        decimal tax;

        if (grossPay > 5000)
        {
            tax = grossPay * 0.30m;
        }
        else if (grossPay > 3000)
        {
            tax = grossPay * 0.20m;
        }
        else
        {
            tax = grossPay * 0.10m;
        }

        decimal netPay = grossPay - tax;

        Console.WriteLine($"Employee: {name}");
        Console.WriteLine("Type: Freelancer");
        Console.WriteLine($"Gross pay: {grossPay:C}");
        Console.WriteLine($"Tax: {tax:C}");
        Console.WriteLine($"Insurance: {0m:C}");
        Console.WriteLine($"Net pay: {netPay:C}");
        Console.WriteLine("--------------------");
    }

    private bool IsValidEmployeeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid employee name.");
            return false;
        }

        return true;
    }

    private bool IsValidSalary(decimal salary)
    {
        if (salary <= 0)
        {
            Console.WriteLine("Invalid salary.");
            return false;
        }
        
        return true;
    }

    private bool IsValidPerformanceScore(int performanceScore)
    {
        if (performanceScore < 0 || performanceScore > 100)
        {
            Console.WriteLine("Invalid performance score.");
            return false;
        }

        return true;
    }

    private bool IsValidHourlyRate(decimal hourlyRate)
    {
        if (hourlyRate <= 0)
        {
            Console.WriteLine("Invalid hourly rate.");
            return false;
        }

        return true;
    }

    private bool IsValidHoursWorked(int hoursWorked)
    {
        if (hoursWorked < 0)
        {
            Console.WriteLine("Invalid hours worked.");
            return false;
        }

        return true;
    }

    private decimal CalculateBonus(decimal monthlySalary, int performanceScore)
    {
        return performanceScore switch
        {
            >= 90 => monthlySalary * 0.20m,
            >= 75 => monthlySalary * 0.10m,
            >= 60 => monthlySalary * 0.05m,
            _ => 0
        };
    }

    private decimal CalculateTax(decimal grossPay)
    {
        return grossPay switch
        {
            > 5000 => grossPay * 0.30m,
            > 3000 => grossPay * 0.20m,
            _ => grossPay * 0.10m
        };
    }

    private void PrintPayroll(string name, decimal grossPay, decimal tax, decimal insuranceCost,string type)
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
