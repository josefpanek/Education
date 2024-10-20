namespace Rpg;

public class Enemy : Character, IAttacable
{
    public override int Health { get; set; }
    
    public override string Name { get; set; }
    
    public Inventory<Weapon> EnemyWeaponInventory { get; set; }
    
    public Inventory<Potion> EnemyPotionInventory { get; set; }
    
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
        EnemyWeaponInventory = new Inventory<Weapon>();
        EnemyPotionInventory = new Inventory<Potion>();
    }

    
    public override void Attack(Character target)
    {
        target.Health -= 1; 
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
}