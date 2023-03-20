
public class Sales : Employee
{
    protected decimal SalesVolume { get; set; }
    protected decimal Commission { get; set; }

    public Sales(int id, string name, decimal loggedHours, decimal wage, decimal SalesVolume , decimal Commission) : base(id, name, loggedHours, wage)
    {
        this.SalesVolume = SalesVolume;
        this.Commission = Commission;
    }

    protected override decimal Calculate()
    {
        return base.Calculate() + calculateBonus();
    }

    private decimal calculateBonus()
    {
        return SalesVolume * Commission;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nCommision: ${Math.Round(Commission,2):N0}$" +
            $"\nBonus: ${Math.Round(calculateBonus(), 2):N0}" +
            $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";

    }
}






