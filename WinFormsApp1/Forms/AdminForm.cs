using Gym_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        private List<Sala> sali = new List<Sala>()
        {
            new Sala() { Nume = "Sala A", Zone = new List<Zona>() { new Zona() { Tip = "Cardio", Capacitate = 20 } } },
            new Sala() { Nume = "Sala B", Zone = new List<Zona>() { new Zona() { Tip = "Forță", Capacitate = 15 } } }
        };


        private List<Abonament> abonamente = new List<Abonament>()
        {
            new Abonament() { Nume = "Lunar Full", Pret = 150, DurataLuni = 1, TipAcces = "Full" },
            new Abonament() { Nume = "Anual Clase", Pret = 1200, DurataLuni = 12, TipAcces = "Clase" }
        };


        private List<Antrenor> antrenori = new List<Antrenor>()
        {
            new Antrenor() { Nume = "Andrei Pop", Specializare = "Cardio" },
            new Antrenor() { Nume = "Maria Ionescu", Specializare = "Yoga" }
        };

        private List<ClasaFitness> clase = new List<ClasaFitness>();



        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshSali();
            RefreshAbonamente();
            cmbAntrenori.DataSource = antrenori;
            RefreshClase();

        }

        private void RefreshSali()
        {
            dgvSali.DataSource = null;
            dgvSali.DataSource = sali.Select(s => new { s.Nume }).ToList();
        }

        private void RefreshAbonamente()
        {
            dgvAbonamente.DataSource = null;
            dgvAbonamente.DataSource = abonamente
                .Select(a => new
                {
                    a.Nume,
                    a.Pret,
                    a.DurataLuni,
                    a.TipAcces
                })
                .ToList();
        }

        private void RefreshClase()
        {
            dgvClase.DataSource = null;
            dgvClase.DataSource = clase.Select(c => new
            {
                c.Nume,
                c.DurataMinute,
                c.Capacitate,
                Antrenor = c.Antrenor?.Nume
            }).ToList();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSali_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    dgvZone.DataSource = null;
                    dgvZone.DataSource = salaSelectata.Zone.Select(z => new { z.Tip, z.Capacitate }).ToList();
                }
            }
        }


        private void btnAdaugaSala_Click(object sender, EventArgs e)
        {
            string numeSala = Microsoft.VisualBasic.Interaction.InputBox("Introdu numele sălii:", "Adaugă Sală", "");
            if (!string.IsNullOrWhiteSpace(numeSala))
            {
                sali.Add(new Sala() { Nume = numeSala });
                RefreshSali();
            }
        }

        private void btnModificaSala_Click(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    string nouNume = Microsoft.VisualBasic.Interaction.InputBox("Modifică numele sălii:", "Modifică Sală", salaSelectata.Nume);
                    if (!string.IsNullOrWhiteSpace(nouNume))
                    {
                        salaSelectata.Nume = nouNume;
                        RefreshSali();
                    }
                }
            }
        }

        private void btnStergeSala_Click(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    var confirm = MessageBox.Show($"Sigur vrei să ștergi sala {salaSelectata.Nume}?", "Confirmare", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        sali.Remove(salaSelectata);
                        RefreshSali();
                        dgvZone.DataSource = null; // golim zonele pentru că sala nu mai există
                    }
                }
            }
        }

        private void btnAdaugaZona_Click(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    string tipZona = Microsoft.VisualBasic.Interaction.InputBox("Tip zona:", "Adaugă Zonă", "");
                    string capacitateStr = Microsoft.VisualBasic.Interaction.InputBox("Capacitate:", "Adaugă Zonă", "10");
                    if (!string.IsNullOrWhiteSpace(tipZona) && int.TryParse(capacitateStr, out int capacitate))
                    {
                        salaSelectata.Zone.Add(new Zona() { Tip = tipZona, Capacitate = capacitate });
                        dgvZone.DataSource = salaSelectata.Zone.Select(z => new { z.Tip, z.Capacitate }).ToList();
                    }
                }
            }
        }

        private void btnModificaZona_Click(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null && dgvZone.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    string zonaTip = dgvZone.CurrentRow.Cells[0].Value.ToString();
                    Zona zonaSelectata = salaSelectata.Zone.FirstOrDefault(z => z.Tip == zonaTip);
                    if (zonaSelectata != null)
                    {
                        string nouTip = Microsoft.VisualBasic.Interaction.InputBox("Tip zonă:", "Modifică Zonă", zonaSelectata.Tip);
                        string capacitateStr = Microsoft.VisualBasic.Interaction.InputBox("Capacitate:", "Modifică Zonă", zonaSelectata.Capacitate.ToString());
                        if (!string.IsNullOrWhiteSpace(nouTip) && int.TryParse(capacitateStr, out int capacitate))
                        {
                            zonaSelectata.Tip = nouTip;
                            zonaSelectata.Capacitate = capacitate;
                            dgvZone.DataSource = salaSelectata.Zone.Select(z => new { z.Tip, z.Capacitate }).ToList();
                        }
                    }
                }
            }
        }


        private void btnStergeZona_Click(object sender, EventArgs e)
        {
            if (dgvSali.CurrentRow != null && dgvZone.CurrentRow != null)
            {
                string salaNume = dgvSali.CurrentRow.Cells[0].Value.ToString();
                Sala salaSelectata = sali.FirstOrDefault(s => s.Nume == salaNume);
                if (salaSelectata != null)
                {
                    string zonaTip = dgvZone.CurrentRow.Cells[0].Value.ToString();
                    Zona zonaSelectata = salaSelectata.Zone.FirstOrDefault(z => z.Tip == zonaTip);
                    if (zonaSelectata != null)
                    {
                        var confirm = MessageBox.Show($"Sigur vrei să ștergi zona {zonaSelectata.Tip}?", "Confirmare", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            salaSelectata.Zone.Remove(zonaSelectata);
                            dgvZone.DataSource = salaSelectata.Zone.Select(z => new { z.Tip, z.Capacitate }).ToList();
                        }
                    }
                }
            }
        }


        private void btnAdaugaAbonament_Click(object sender, EventArgs e)
        {
            string nume = Microsoft.VisualBasic.Interaction.InputBox("Nume abonament:");
            string pretStr = Microsoft.VisualBasic.Interaction.InputBox("Preț:");
            string durataStr = Microsoft.VisualBasic.Interaction.InputBox("Durata (luni):");
            string tip = Microsoft.VisualBasic.Interaction.InputBox("Tip acces:");

            if (decimal.TryParse(pretStr, out decimal pret) &&
                int.TryParse(durataStr, out int durata) &&
                !string.IsNullOrWhiteSpace(nume))
            {
                abonamente.Add(new Abonament
                {
                    Nume = nume,
                    Pret = pret,
                    DurataLuni = durata,
                    TipAcces = tip
                });

                RefreshAbonamente();
            }
        }

        private void btnModificaAbonament_Click(object sender, EventArgs e)
        {
            if (dgvAbonamente.CurrentRow == null) return;

            string nume = dgvAbonamente.CurrentRow.Cells[0].Value.ToString();
            Abonament a = abonamente.First(x => x.Nume == nume);

            string nouPret = Microsoft.VisualBasic.Interaction.InputBox("Preț:", "", a.Pret.ToString());
            string nouDurata = Microsoft.VisualBasic.Interaction.InputBox("Durata:", "", a.DurataLuni.ToString());

            if (decimal.TryParse(nouPret, out decimal p) &&
                int.TryParse(nouDurata, out int d))
            {
                a.Pret = p;
                a.DurataLuni = d;
                RefreshAbonamente();
            }
        }

        private void btnStergeAbonament_Click(object sender, EventArgs e)
        {
            if (dgvAbonamente.CurrentRow == null) return;

            string nume = dgvAbonamente.CurrentRow.Cells[0].Value.ToString();
            Abonament a = abonamente.First(x => x.Nume == nume);

            var confirm = MessageBox.Show("Ștergi abonamentul?", "Confirmare", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                abonamente.Remove(a);
                RefreshAbonamente();
            }
        }

        private void btnAdaugaClasa_Click(object sender, EventArgs e)
        {
            string nume = Microsoft.VisualBasic.Interaction.InputBox("Nume clasă:");
            string durataStr = Microsoft.VisualBasic.Interaction.InputBox("Durata (minute):");
            string capacitateStr = Microsoft.VisualBasic.Interaction.InputBox("Capacitate:");

            if (int.TryParse(durataStr, out int durata) &&
                int.TryParse(capacitateStr, out int capacitate) &&
                cmbAntrenori.SelectedItem is Antrenor antrenor)
            {
                clase.Add(new ClasaFitness
                {
                    Nume = nume,
                    DurataMinute = durata,
                    Capacitate = capacitate,
                    Antrenor = antrenor
                });

                RefreshClase();
            }
        }


        private void btnModificaClasa_Click(object sender, EventArgs e)
        {
            if (dgvClase.CurrentRow == null) return;

            string nume = dgvClase.CurrentRow.Cells[0].Value.ToString();
            ClasaFitness clasa = clase.First(c => c.Nume == nume);

            string durataStr = Microsoft.VisualBasic.Interaction.InputBox("Durata:", "", clasa.DurataMinute.ToString());
            string capacitateStr = Microsoft.VisualBasic.Interaction.InputBox("Capacitate:", "", clasa.Capacitate.ToString());

            if (int.TryParse(durataStr, out int durata) &&
                int.TryParse(capacitateStr, out int capacitate))
            {
                clasa.DurataMinute = durata;
                clasa.Capacitate = capacitate;
                clasa.Antrenor = cmbAntrenori.SelectedItem as Antrenor;
                RefreshClase();
            }
        }


        private void btnStergeClasa_Click(object sender, EventArgs e)
        {
            if (dgvClase.CurrentRow == null) return;

            string nume = dgvClase.CurrentRow.Cells[0].Value.ToString();
            ClasaFitness clasa = clase.First(c => c.Nume == nume);

            if (MessageBox.Show("Ștergi clasa?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clase.Remove(clasa);
                RefreshClase();
            }
        }



        private void dgvAbonamente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
