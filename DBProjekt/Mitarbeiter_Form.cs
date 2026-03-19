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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CasinoDaten.SaveChanges();
        }
    }
}
