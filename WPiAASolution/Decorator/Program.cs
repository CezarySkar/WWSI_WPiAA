using Decorator;

Console.WriteLine("Pay with: \n1. cash\n2. card\n3. transfer");
var method = Console.ReadLine();

var shop = new Shop();

shop.Pay(method!, 10.52m);