using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjekt
{
    public partial class Transaktion_Form : Form
    {
        g5_6it23Entities1 CasinoDaten = new g5_6it23Entities1();

        public Transaktion_Form()
        {
            InitializeComponent();
            casino_transaktionBindingSource.DataSource = CasinoDaten.casino_transaktion.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Editieren
            casino_transaktionBindingSource.EndEdit();
            CasinoDaten.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hinzufugen
            var current = casino_transaktionBindingSource.Current as casino_transaktion;
            CasinoDaten.casino_transaktion.Add(current);
            casino_transaktionBindingSource.EndEdit();
            CasinoDaten.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Löschen
            var current_gast = casino_transaktionBindingSource.Current as casino_transaktion;
            var confirm_msg = MessageBox.Show("Transaktion: " + current_gast.PK_Transaktion+ " Löschen?", "Wirklich Löschen?", MessageBoxButtons.YesNo);
            if (confirm_msg == DialogResult.Yes)
            {
                CasinoDaten.casino_transaktion.Remove(current_gast);
                CasinoDaten.SaveChanges();
                casino_transaktionBindingSource.ResetBindings(false);
            }
        }
    }
}
