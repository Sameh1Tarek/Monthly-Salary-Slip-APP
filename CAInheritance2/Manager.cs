public class Manager : Employee
{
    private const decimal AllowenceRate = 0.05m;

    public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
    {
        
    }
    protected override decimal Calculate()
    {
        return base.Calculate() + calculateAllowence();
    }

    private decimal calculateAllowence()
    {
        return AllowenceRate * base.Calculate();
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nAllowence: ${Math.Round(calculateAllowence(),2):N0}" +
            $"\nNet Salary: ${Math.Round(this.Calculate(),2):N0}";

    }
}
