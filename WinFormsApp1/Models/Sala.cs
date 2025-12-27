using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Models
{
    public class Sala
    {
        public string Nume { get; set; }
        public List<Zona> Zone { get; set; } = new List<Zona>();

        public string GetDetalii()
        {
            if (Zone.Count == 0)
                return $"Sala: {Nume}, fără zone";

            string zoneDetalii = string.Join(", ", Zone.Select(z => z.Tip));
            return $"Sala: {Nume}, Zone: {zoneDetalii}";
        }
    }

}
