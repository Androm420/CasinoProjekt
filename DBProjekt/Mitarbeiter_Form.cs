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
    public partial class Mitarbeiter_Form : Form
    {
        g5_6it23Entities1 CasinoDaten = new g5_6it23Entities1();

        public Mitarbeiter_Form()
        {
            InitializeComponent();
            casino_mitarbeiterBindingSource.DataSource = CasinoDaten.casino_mitarbeiter.ToList();
            Raum.DataSource = CasinoDaten.casino_raeume.ToList();
            comboBox1.DataSource = CasinoDaten.casino_rollen.ToList();
            comboBox1.DisplayMember = "Bezeichnung";
            comboBox1.ValueMember = "PK_Rolle";
            Raum.ValueMember = "PK_Raum";
            Raum.DisplayMember = "Raumbezeichnung";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casino_mitarbeiterBindingSource.EndEdit();
            CasinoDaten.SaveChanges();
        }
        //filter nach rollen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = CasinoDaten.casino_mitarbeiter.Where(a => a.FK_Rolle == comboBox1.SelectedIndex+1).ToList();
            casino_mitarbeiterBindingSource.DataSource = query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var current = casino_mitarbeiterBindingSource.Current as casino_mitarbeiter;
            current.FK_Rolle = (int)comboBox1.SelectedValue;
            current.FK_Raum = (int)Raum.SelectedValue;
            casino_mitarbeiterBindingSource.EndEdit();
            CasinoDaten.casino_mitarbeiter.Add(current);
            casino_mitarbeiterBindingSource.ResetBindings(false);
            CasinoDaten.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var current_gast = casino_mitarbeiterBindingSource.Current as casino_mitarbeiter;
            var confirm_msg = MessageBox.Show("Mitarbeiter: " + current_gast.Name + " Löschen?", "Wirklich Löschen?", MessageBoxButtons.YesNo);
            if (confirm_msg == DialogResult.Yes)
            {
                CasinoDaten.casino_mitarbeiter.Remove(current_gast);
                CasinoDaten.SaveChanges();
                casino_mitarbeiterBindingSource.ResetBindings(false);
            }
        }
    }
}
