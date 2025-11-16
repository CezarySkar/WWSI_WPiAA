using Builder;
using Builder.Interfaces;

var wojsko = new List<IWarrior>();
var garnizon = new Garnizon();

for (int i = 0; i< 2; i++)
{
    garnizon.StrzelectBuilder.CreateWarrior($"Strzelec {i + 1}");
    garnizon.StrzelectBuilder.GetWeapon();
    garnizon.StrzelectBuilder.Train();
    wojsko.Add(garnizon.StrzelectBuilder.GetWarrior());
    Console.WriteLine("\n");

    garnizon.KonnyBuilder.CreateWarrior($"Konny {i + 1}");
    garnizon.KonnyBuilder.GetWeapon();
    garnizon.KonnyBuilder.Train();
    wojsko.Add(garnizon.KonnyBuilder.GetWarrior());
    Console.WriteLine("\n");

    garnizon.PiechurBuilder.CreateWarrior($"Piechur {i + 1}");
    garnizon.PiechurBuilder.GetWeapon();
    garnizon.PiechurBuilder.Train();
    wojsko.Add(garnizon.PiechurBuilder.GetWarrior());
    Console.WriteLine("\n\n");
}

foreach(var wojownik in wojsko)
{
    wojownik.Attack();
    Console.WriteLine("\n");
}