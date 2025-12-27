using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Models
{
    public class Antrenor
    {
        public string Nume { get; set; }
        public string Specializare { get; set; }

        public override string ToString()
        {
            return $"{Nume} ({Specializare})";
        }
    }
}
