namespace Rpg;

public class Weapon
{
    public string WeaponName { get; set; }
}

public class Sword : Weapon
{
    public int MeleeAttack { get; set; }
    public bool TwoHanded { get; set; }

    public override string ToString()
    {
        return $"{WeaponName}";
    }

    public Sword(string name, bool twoHanded, int meleeAttack)
    {
        WeaponName = name;
        TwoHanded = twoHanded;
        MeleeAttack = meleeAttack;
    }
}

public class Bow : Weapon
{
    public int Range { get; set; }
    
    public int RangedAttack { get; set; }
    
    public int Ammunition { get; set; }

    public override string ToString()
    {
        return $"{WeaponName}";
    }

    public Bow(string name, int range, int rangedAttack, int ammunition)
    {
        WeaponName = name;
        Range = range;
        RangedAttack = rangedAttack;
        Ammunition = ammunition;
    }
}