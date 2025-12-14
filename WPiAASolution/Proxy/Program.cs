using Proxy;

Console.WriteLine("Wpisz typ skarbca (open/protected):");
string vaultType = Console.ReadLine() ?? string.Empty;
var vaultProxy = new VaultProxy();
Console.WriteLine(vaultProxy.GetObject(vaultType));
