
public class Developer : Employee
{
    private const decimal Commission = 0.03m;
    protected bool TaskCompleted { get; set; }

    public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompleted) : base(id, name, loggedHours, wage)
    {
        this.TaskCompleted = taskCompleted;
    }
    protected override decimal Calculate()
    {
        return base.Calculate() + calculateBonus();
    }

    private decimal calculateBonus()
    {
        if(TaskCompleted)
          return base.Calculate() * Commission;
        return 0;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nTak Completed: ${(TaskCompleted ? "Yes" : "No")}" +
            $"\nBonus: ${Math.Round(calculateBonus(), 2):N0}" +
            $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";

    }
}









