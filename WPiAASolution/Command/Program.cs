using Command;

var factory = new SantaClausFactory();
var elf = new Elf();

elf.AddCommand(new CreateToyCommand(factory, "Teddy Bear"));
elf.AddCommand(new CreateToyCommand(factory, "Toy Car"));
elf.AddCommand(new CreateToyCommand(factory, "Toy House"));

elf.AddCommand(new CreateRodCommand(factory, "Wooden Rod"));

elf.ExecuteCommands();

foreach (var item in factory.ProducedItems)
{
    Console.WriteLine($"Prepared item: {item}");
}