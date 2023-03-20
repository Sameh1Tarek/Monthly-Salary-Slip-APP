public class Employee
{
    public const int MinimumLoggedHours = 176;
    public const decimal OverTimeRate = 1.25m;

    protected Employee(int id, string name, decimal loggedHours, decimal wage)
    {
        Id = id;
        Name = name;
        LoggedHours = loggedHours;
        Wage = wage;
    }

    protected int Id { get; set; }

    protected string Name { get; set; }

    protected decimal LoggedHours { get; set; } 

    protected decimal Wage { get; set; }

    private decimal calculateBaseSalary()
    {
        return Wage * LoggedHours;
    }

    private decimal calculateOverTime()
    {
        var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
        return Wage * additionalHours * OverTimeRate;
    }

    protected virtual decimal Calculate()
    {
        return calculateBaseSalary()+calculateOverTime();
    }

    
    public override string ToString()
    {
        return $"\n{GetType()}" +
               $"\nId: {Id}" +
               $"\nName: {Name}" +
               $"\nLogged Hours: {LoggedHours} hrs" +
               $"\nWage: {Wage} $/hr" +
               $"\nBase Salary: ${Math.Round(calculateBaseSalary(), 2):N0}" +
               $"\nOver Time: ${Math.Round(calculateOverTime(),2):N0}";
        

    }

}
