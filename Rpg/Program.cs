using System.Threading.Channels;
using Rpg;

var pepa = new Player("Pepa", 50);
var toman = new Enemy("Toman", 50);

pepa.PlayerWeaponInventory.AddItem(new Sword("Sting", false, 20));
pepa.PlayerWeaponInventory.AddItem(new Bow("Bow of the Galadhrim", 80, 20, 80));

// pepa.PlayerWeaponInventory.AddItem(new Sword());
// pepa.PlayerPotionInventory.AddItem(new DexterityPotion());
// pepa.PlayerPotionInventory.AddItem(new HealingPotion());
// Console.WriteLine($"Pepa's weaponry: {pepa.PlayerWeaponInventory.ShowInventory()}");
// Console.WriteLine($"Pepa's potion(s): {pepa.PlayerPotionInventory.ShowInventory()}");
//
// pepa.PlayerWeaponInventory.ShowInventory().ForEach(c => Console.WriteLine($"{c}"));
// pepa.PlayerPotionInventory.ShowInventory().ForEach(c => Console.WriteLine($"{c}"));
//
//
// while (pepa.Health > 0 && toman.Health > 0)
// {
//     pepa.Attack(toman);
//     toman.Attack(pepa);
// }

pepa.PlayerWeaponInventory.ShowInventory().ForEach(Console.WriteLine);
CombatClass.Combat<Character>(pepa, toman);