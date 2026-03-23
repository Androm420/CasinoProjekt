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
    public partial class Gast_Form : Form
    {
        g5_6it23Entities1 CasinoDaten = new g5_6it23Entities1();

        public Gast_Form()
        {
            InitializeComponent();
            casino_gastBindingSource.DataSource = CasinoDaten.casino_gast.ToList();
            
                    sperrstatusCheckBox.Text = "Gesperrt";
                    vIPCheckBox.Text = "VIP";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casino_gastBindingSource.EndEdit();
            CasinoDaten.SaveChanges();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query_vip = CasinoDaten.casino_gast.Where(a => a.VIP == true).ToList();
            var query_gespert = CasinoDaten.casino_gast.Where(a => a.Sperrstatus == true).ToList();
            switch (comboBox1.SelectedIndex)
            {
                default:
                    break;
                case 0:
                    casino_gastBindingSource.DataSource = query_vip;
                    casino_gastBindingSource.ResetBindings(false);
                    break;
                case 1:

                    casino_gastBindingSource.DataSource = query_gespert;
                    casino_gastBindingSource.ResetBindings(false);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = CasinoDaten.casino_gast.Where(a => a.Ausweisnummer.Contains(textBox1.Text)).Select(al => al).ToList();
            casino_gastBindingSource.DataSource = query;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var query = CasinoDaten.casino_gast.Where(a => a.Geburtsdatum == dateTimePicker1.Value).ToList();
            casino_gastBindingSource.DataSource = query;
        }
    }
}
