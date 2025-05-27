using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2.Alone
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance =
            new Lazy<Authenticator>(() => new Authenticator(), true);

        public static Authenticator Instance => _instance.Value;

        public Guid Id { get; }

        private Authenticator()
        {
            Id = Guid.NewGuid();
        }

        public bool Login(string username, string password)
        {
            return username == "admin" && password == "root";
        }
    }
}



