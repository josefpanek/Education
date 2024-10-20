namespace Rpg;

public static class CombatClass
{
    public static void Combat<TCharacter>(TCharacter attacker, TCharacter defender) where TCharacter : Character
    {
        while (defender.Health > 0 && attacker.Health > 0)
        {
            Console.WriteLine($"{attacker.Name} is attacking {defender.Name}.");
            attacker.Attack(defender);
            Console.WriteLine($"{defender.Name} has currently {defender.Health} HP.");
            (attacker, defender) = (defender, attacker);
        }

        Console.WriteLine("Fight ended.");
    }
}