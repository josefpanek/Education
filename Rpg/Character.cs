namespace Rpg;

public abstract class Character
{
    public abstract int Health { get; set; }
    
    public abstract string Name { get; set; }

    public abstract void Attack(Character target);
}