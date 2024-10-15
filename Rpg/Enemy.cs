namespace Rpg;

public class Enemy : Character, IAttacable
{
    public override int Health { get; set; }
    
    public override string Name { get; set; }
    
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    
    public override void Attack(Character target)
    {
        target.Health -= 1; 
        Console.WriteLine($"Player {Name} attacks {target.Name}. {target.Name} has {target.Health} HP.");
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"Player {Name} was attacked and lost {amount} HP. Currently has {Health} HP.");
    }
}