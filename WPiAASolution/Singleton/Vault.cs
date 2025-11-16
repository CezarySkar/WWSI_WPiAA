using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Vault
    {
        private static Vault? _instance;
        private static readonly object _lock = new object();
        private readonly string _vaultKey;
        private Vault()
        {
            _vaultKey = GenerateVaultKey();
        }
        public static Vault GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Vault();
                    }
                }
            }
            return _instance;
        }

        public string GetVaultKey()
        {
            return _vaultKey;
        }

        private string GenerateVaultKey()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
