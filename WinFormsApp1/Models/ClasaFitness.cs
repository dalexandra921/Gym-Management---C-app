using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Models
{
    public class ClasaFitness
    {
        public string Nume { get; set; }
        public int DurataMinute { get; set; }
        public int Capacitate { get; set; }
        public Antrenor Antrenor { get; set; }

        public string GetDetalii()
        {
            return $"{Nume} - {DurataMinute} min - {Capacitate} locuri - {Antrenor?.Nume}";
        }
    }
}
