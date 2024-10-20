namespace Rpg;

public class Potion
{
    public string PotionName { get; set; }
}

public class HealingPotion : Potion
{
    public int HealthValue { get; set; }
}

public class MagicPotion : Potion
{
    public int ManaValue { get; set; }
}

public class DexterityPotion : Potion
{
    public int DexterityValue { get; set; }
}