using Singleton;

var key1 = Vault.GetInstance().GetVaultKey();
var key2 = Vault.GetInstance().GetVaultKey();

Console.WriteLine($"Vault\n------\nKey 1: {key1}\nKey 2: {key2}\n------");