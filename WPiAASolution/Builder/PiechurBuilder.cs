using Builder.Interfaces;
using Builder.Units;

namespace Builder
{
    internal class PiechurBuilder : WarriorBuilder
    {
        internal override void CreateWarrior(string name)
        {
            Wojownik = new Piechur(name);
            Console.WriteLine($"Nowy ochotnik: {Wojownik.Name}");
        }

        internal override void GetWeapon()
        {
            Wojownik.Weapon = "Miecz";
            Console.WriteLine($"{Wojownik.Name} otrzymał broń: {Wojownik.Weapon}");
        }

        internal override void Train()
        {
            Console.WriteLine($"{Wojownik.Name} przechodzi trening");
        }
    }
}
