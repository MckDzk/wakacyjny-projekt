public class Monster : Character
{
    public Monster(string name, int health, int attack) : base(name, health, attack)
    {
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Potwór: {Name}, Zdrowie: {Health}, Atak: {Attack}");
    }
}