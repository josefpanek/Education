using Rpg;

var pepa = new Player("Pepa", 50);
var toman = new Enemy("Toman", 50);

pepa.Attack(toman);
toman.Attack(pepa);