using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjekt
{
    public partial class Spiele : Form
    {
        g5_6it23Entities1 daten = new g5_6it23Entities1();
        public Spiele()
        {
            InitializeComponent();
            comboBox1.DataSource = daten.casino_raeume.ToList();
            comboBox1.DisplayMember = "Raumbezeichnung";
            comboBox1.ValueMember = "PK_Raum";

        }

        private void Spiele_Load(object sender, EventArgs e)
        {
            casino_spielBindingSource.DataSource = daten.casino_spiel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Spiel Hinzufugen
            var current = casino_spielBindingSource.Current as casino_spiel;
            current.FK_Raum = (int)comboBox1.SelectedValue;
            casino_spielBindingSource.EndEdit();
            daten.casino_spiel.Add(current);
            casino_spielBindingSource.ResetBindings(false);
            daten.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editieren
            casino_spielBindingSource.EndEdit();
            daten.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Löschen
            var current_gast = casino_spielBindingSource.Current as casino_spiel;
            var confirm_msg = MessageBox.Show("Spiel: " + current_gast.Bezeichnung+ " Löschen?", "Wirklich Löschen?", MessageBoxButtons.YesNo);
            if (confirm_msg == DialogResult.Yes)
            {
                daten.casino_spiel.Remove(current_gast);
                daten.SaveChanges();
                casino_spielBindingSource.ResetBindings(false);
            }
        }
    }
}
