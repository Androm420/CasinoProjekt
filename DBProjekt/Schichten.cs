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
    public partial class Schichten : Form
    {
        g5_6it23Entities1 CasinoDaten = new g5_6it23Entities1();

        public Schichten()
        {
            InitializeComponent();
            casino_schichtBindingSource.DataSource = CasinoDaten.casino_schicht.ToList();
        }
    }
}
