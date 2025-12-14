using Facade;

var weatherFacade = new WeatherFacade();
Console.WriteLine("Wpisz miasto");
var city = Console.ReadLine();

var temp = await weatherFacade.GetOpenWeatherTemp(city!);
Console.WriteLine($"Temperatura w mieście {city} wynosi {temp} °C");