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
    public partial class Rollen : Form
    {
        g5_6it23Entities1 daten = new g5_6it23Entities1();
        public Rollen()
        {
            InitializeComponent();
            casino_rollenBindingSource.DataSource = daten.casino_rollen.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casino_rollenBindingSource.EndEdit();
            daten.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var current = casino_rollenBindingSource.Current as casino_rollen;
            casino_rollenBindingSource.EndEdit();
            daten.casino_rollen.Add(current);
            casino_rollenBindingSource.ResetBindings(false);
            daten.SaveChanges();
        }
    }
}
