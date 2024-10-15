namespace Rpg;

public class Weapon
{
    public string WeaponName { get; set; }
    
    public int MeleeAttack { get; set; }
}

public class Sword : Weapon
{
    public bool TwoHanded { get; set; }
}

public class Bow : Weapon
{
    public int Range { get; set; }
    
    public int RangedAttack { get; set; }
    
    public int Ammunition { get; set; }
}