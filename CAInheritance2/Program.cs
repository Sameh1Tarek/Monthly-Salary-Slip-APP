internal class Program
{
    private static void Main(string[] args)
    {
        Manager m = new Manager(1, "Sameh", 180, 10);

        Maintanence ms = new Maintanence(2, "Ahmd", 187, 8);

        Sales s = new Sales(3, "Tarek", 176, 10, 0.05m, 10000m);

        Developer d = new Developer(4, "Issam", 186, 15, true);

        Employee[] employees = {m , ms, s , d}; 
        foreach (Employee e in employees)
        {
            Console.WriteLine($"\n----------------------------");
            Console.WriteLine(e);
        }
       
    }
}
