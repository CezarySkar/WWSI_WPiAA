using Builder.Interfaces;
using Builder.Units;

namespace Builder
{
    internal class StrzelectBuilder : WarriorBuilder
    {
        internal override void CreateWarrior(string name)
        {
            Wojownik = new Strzelec(name);
            Console.WriteLine($"Nowy strzelec na ochotnika: {Wojownik.Name}");
        }

        internal override void GetWeapon()
        {
            Wojownik.Weapon = "Łuk";
            Console.WriteLine($"{Wojownik.Name} otrzymał broń dystansową {Wojownik.Weapon}");
        }

        internal override void Train()
        {
            Console.WriteLine($"Trening strzelca: {Wojownik.Name}");
        }
    }
}
