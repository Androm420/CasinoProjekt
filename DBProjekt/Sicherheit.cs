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
    }
}
