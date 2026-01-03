using Strategy;

Console.WriteLine("Wybierz 1 dla bazy Pexels lub 2 dla Pixabay");
int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine("Wybierz kategorię:");
string category = Console.ReadLine()!;

switch (choice)
{
    case 1:
        {
            var pexelsService = new PhotoDatabase();
            pexelsService.SetStrategy(new PexelsDatabase());
            await pexelsService.SearchPhotos(category);
            break;
        }
    case 2:
        {
            var pixabayService = new PhotoDatabase();
            pixabayService.SetStrategy(new PixabayDatabase());
            await pixabayService.SearchPhotos(category);
            break;
        }
    default:
        {
            Console.WriteLine("Nieprawidłowy wybór");
            break;
        }
}