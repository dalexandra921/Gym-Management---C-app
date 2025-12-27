using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management.Models
{
    public class Abonament
    {
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public int DurataLuni { get; set; } // ex: 1, 3, 12
        public string TipAcces { get; set; } // Full, Clase, Cardio etc.

        public string GetDetalii()
        {
            return $"{Nume} - {Pret} lei / {DurataLuni} luni ({TipAcces})";
        }
    }

}
