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
    public partial class Raume_Form : Form
    {
        g5_6it23Entities1 Casinodaten = new g5_6it23Entities1();
        public Raume_Form()
        {
            InitializeComponent();
            casino_raeumeBindingSource.DataSource = Casinodaten.casino_raeume.ToList();

        }
    }
}
