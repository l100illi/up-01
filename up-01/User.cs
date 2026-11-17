using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_01
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string Role { get; set; } = "User";
        public decimal Balance { get; set; } = 0m;

        public User() { }

        public User(int id, string login, string email, string displayName)
        {
            Id = id;
            Login = login;
            Email = email;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return $"User #{Id}: {DisplayName} ({Login}), Email: {Email}, " +
                   $"Role: {Role}, Active: {IsActive}, Balance: {Balance:C}";
        }
    }
}

