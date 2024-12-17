using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject.SolidPrinciples
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    // Class responsible for user data storage
    public class UserRepository
    {
        public void Save(User user)
        {

            Console.WriteLine($"User {user.Name} saved to database.");
        }
    }

    // Class responsible for email notifications
    public class EmailService
    {
        public void SendEmail(User user, string message)
        {
            Console.WriteLine($"Email sent to {user.Email}: {message}");
        }
    }
}
