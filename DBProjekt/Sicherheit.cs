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
    public partial class Sicherheit : Form
    {
        g5_6it23Entities1 daten = new g5_6it23Entities1();
        public Sicherheit()
        {
            InitializeComponent();
            casino_sicherheitsvorfallBindingSource.DataSource = daten.casino_sicherheitsvorfall.ToList();
        }

        private void casino_sicherheitsvorfallDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = casino_sicherheitsvorfallBindingSource?.Current as casino_sicherheitsvorfall;
            var query = daten.casino_sicherheitsvorfall
           .Where(al => al.FK_Gast == current.FK_Gast)
           .Select(al => al.casino_gast)
           .Distinct()
           .ToList();

            var query2 = daten.casino_sicherheitsvorfall
                .Where(ao => ao.FK_Mitarbeiter == current.FK_Mitarbeiter)
                .Select(ao => ao.casino_mitarbeiter)
                .Distinct()
                .ToList();

            casino_gastBindingSource.DataSource = query;
            casino_mitarbeiterBindingSource.DataSource = query2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var current_gast = casino_sicherheitsvorfallBindingSource?.Current as casino_sicherheitsvorfall;
            var confirm_msg = MessageBox.Show("Sicherheitfall: " + current_gast.Beschreibung+ " Löschen?", "Wirklich Löschen?", MessageBoxButtons.YesNo);
            if (confirm_msg == DialogResult.Yes)
            {
                daten.casino_sicherheitsvorfall.Remove(current_gast);
                daten.SaveChanges();
                casino_gastBindingSource.ResetBindings(false);
            }
        }
    }
}
