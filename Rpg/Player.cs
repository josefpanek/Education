namespace Rpg;

public class Player : Character, IAttacable
{
    public override int Health { get; set; }
    
    public override string Name { get; set; }
    
    public Inventory<Weapon> PlayerWeaponInventory { get; set; }
    
    public Inventory<Potion> PlayerPotionInventory { get; set; }
    
    public Player(string name, int health)
    {
        Name = name;
        Health = health;
        PlayerWeaponInventory = new Inventory<Weapon>();
        PlayerPotionInventory = new Inventory<Potion>();
    }
    
    public override void Attack(Character target)
    {
        target.Health -= 10;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
}