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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Mitarbeiter_Form form2 = new Mitarbeiter_Form();
            form2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gast_Form form = new Gast_Form();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaktion_Form form = new Transaktion_Form();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Schichten form = new Schichten();
            form.Show();
        }
    }
}
