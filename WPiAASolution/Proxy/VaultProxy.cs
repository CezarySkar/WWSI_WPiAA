using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class VaultProxy : IVault
    {
        private string _vaultPassword = "password";
        private bool _isAuthenticated = false;
        public string GetObject(string objTypeToGet)
        {
            if (objTypeToGet == "protected")
            {
                Console.WriteLine("Podaj hasło");
                var pass = Console.ReadLine() ?? string.Empty;
                Authenticate(pass);
                if (_isAuthenticated)
                {
                    IVault vault = new ProtectedVault();
                    return vault.GetObject("Protected");
                }
            }
            else if (objTypeToGet == "open")
            {
                IVault vault = new OpenVault();
                return vault.GetObject("Open");
            }
            return "Access denied.";
        }

        public bool Authenticate(string password)
        {
            if (password == _vaultPassword)
            {
                _isAuthenticated = true;
            }
            return _isAuthenticated;
        }
    }
}
