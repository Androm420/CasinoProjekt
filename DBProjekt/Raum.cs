using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBProjekt
{
    public partial class Raum : Form
    {

        g5_6it23Entities1 casinodata = new g5_6it23Entities1();
        public Raum()
        {
            InitializeComponent();
            casino_raeumeBindingSource.DataSource = casinodata.casino_raeume.ToList();
            casino_spielBindingSource.DataSource = casinodata.casino_spiel.ToList();

        }

        private void Raum_Load(object sender, EventArgs e)
        {

        }

        private void casino_spielDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var aktuell = casino_spielBindingSource?.Current as casino_spiel;
            casino_raeumeBindingSource.DataSource = aktuell.casino_raeume;
        }
    }
}
