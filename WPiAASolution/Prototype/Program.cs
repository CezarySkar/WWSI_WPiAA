using Prototype;

List<Ork> army = [];
Ork originalOrk = new Ork() { Strength = 50 };

army.Add(originalOrk);
for (int i = 0; i < 10; i++)
{
    Ork clonedOrk = originalOrk.Clone();
    army.Add(clonedOrk);
}

foreach (var ork in army)
{
    Console.WriteLine($"Nowy ork dołączył do armii, jego siła to: {ork.Strength}");
}