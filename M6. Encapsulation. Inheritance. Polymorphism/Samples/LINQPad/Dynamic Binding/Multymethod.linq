<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

#region
//Мультиметод (multimethod)
//множественная диспетчеризация (multiple dispatch) 
//механизм, позволяющий выбрать на рантайме одну из нескольких функций в зависимости 
//от динамических типов или значений аргументов. Представляет собой расширение 
//одиночной диспетчеризации (виртуальных функций), где выбор метода осуществляется 
//динамически на основе фактического типа объекта. Множественная диспетчеризация
//обобщает динамическую диспетчеризацию для случаев с двумя или более объектами.
#endregion
class Thing { }
class Asteroid : Thing { }
class Spaceship : Thing { }
 
static void CollideWithImplementation(Thing x, Thing y) 
{
	"нечто сталкивается с чем-то".Dump();
}
 
static void CollideWithImplementation(Asteroid x, Asteroid y)
{
	"астероид сталкивается с астероидом".Dump();
}
 
static void CollideWithImplementation(Asteroid x, Spaceship y) 
{
	"астероид сталкивается с космическим кораблем".Dump();
}
 
static void CollideWithImplementation(Spaceship x, Asteroid y) 
{
	"космический корабль сталкивается с астероидом".Dump();
}
 
static void CollideWithImplementation(Spaceship x, Spaceship y) 
{
	"космический корабль сталкивается с космическим кораблем".Dump();
}
 
static void CollideWith(Thing x, Thing y)
{
	dynamic a = x;
	dynamic b = y;
	CollideWithImplementation(a, b);
	"---".Dump();
	CollideWithImplementation(x, y);
	"---".Dump();
}
 
void Main()
{
	Thing asteroid = new Asteroid();
	Thing spaceship = new Spaceship();
	CollideWith(asteroid, spaceship);
	CollideWith(spaceship, spaceship);
	CollideWith(asteroid, asteroid);
}