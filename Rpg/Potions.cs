namespace Rpg;

public class Potions
{
    public string PotionName { get; set; }
}

public class HealingPotion : Potions
{
    public int HealthValue { get; set; }
}

public class MagicPotion : Potions
{
    public int ManaValue { get; set; }
}

public class DexterityPotion : Potions
{
    public int DexterityValue { get; set; }
}