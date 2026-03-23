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
            comboBox1.DataSource = CasinoDaten.casino_rollen.ToList();
            comboBox1.DisplayMember = "Bezeichnung";
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
    }
}
