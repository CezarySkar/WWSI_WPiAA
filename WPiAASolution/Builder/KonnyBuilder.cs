using Builder.Interfaces;
using Builder.Units;

namespace Builder
{
    internal class KonnyBuilder : WarriorBuilder
    {
        internal override void CreateWarrior(string name)
        {
            Wojownik = new Konny(name);
            Console.WriteLine($"Nowy konny na ochotnika: {Wojownik.Name}");
        }

        internal override void GetWeapon()
        {
            Wojownik.Weapon = "Łuk";
            Console.WriteLine($"{Wojownik.Name} otrzymał swoją lancę {Wojownik.Weapon}");
        }

        internal override void Train()
        {
            Console.WriteLine($"Trening kawalerii: {Wojownik.Name}");
        }
    }
}
