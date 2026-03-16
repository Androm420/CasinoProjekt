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
        g5_6it23Entities CasinoDaten = new g5_6it23Entities();
        public Form1()
        {
            InitializeComponent();
            casino_gastBindingSource.DataSource = CasinoDaten.casino_gast.ToList();
        }

  

    }
}
