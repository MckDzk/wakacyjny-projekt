public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }

    public Character(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void PrintStats()
    {
        Console.WriteLine($"Postać: {Name}, Zdrowie: {Health}, Atak: {Attack}");
    }
    public void UseItem(Item item)
    {
        Health += item.HealthBonus;
        Attack += item.AttackBonus;
    }
}