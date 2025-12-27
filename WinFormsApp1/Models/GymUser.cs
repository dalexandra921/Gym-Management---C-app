using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Models
{
    public class GymUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin sau Client
    
        public string GetDetalii()
        {
            return $"Username: {Username}, Rol: {Role}";
        }

    };

}
    
