using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Models
{
    public class Zona
    {
        public string Tip { get; set; } // ex: Cardio, Forță, Studio
        public int Capacitate { get; set; }

        public string GetDetalii()
        {
            return $"Zona: {Tip}, Capacitate: {Capacitate}";
        }
    }

}
