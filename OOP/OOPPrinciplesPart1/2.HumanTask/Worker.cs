using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public decimal MoneyPerHour()
    {
        decimal moneyPerDay = this.weekSalary / 5;
        return moneyPerDay / this.workHoursPerDay;
    }

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay = 8)
        : base(firstName, lastName)
    {
        this.weekSalary = weekSalary;
        this.workHoursPerDay = workHoursPerDay;
    }

}
