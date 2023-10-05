public class Item
{
    public string Name { get; set; }
    public int HealthBonus { get; set; }
    public int AttackBonus { get; set; }

    public Item(string name, int healthBonus, int attackBonus)
    {
        Name = name;
        HealthBonus = healthBonus;
        AttackBonus = attackBonus;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Przedmiot: {Name}, Bonus zdrowia: {HealthBonus}, Bonus ataku: {AttackBonus}");
    }
}