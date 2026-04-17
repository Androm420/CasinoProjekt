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
            casino_mitarbeiterBindingSource.DataSource = casinodata.casino_mitarbeiter.ToList();
        }

        private void casino_spielDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var aktuell = casino_spielBindingSource?.Current as casino_spiel;
            casino_raeumeBindingSource.DataSource = aktuell.casino_raeume;
        }

        private void casino_raeumeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var current_raum = casino_raeumeBindingSource?.Current as casino_raeume;
            var query = casinodata.casino_raeume.SelectMany(al => al.casino_mitarbeiter.Where(als => als.FK_Raum == current_raum.PK_Raum)).ToList();
            casino_mitarbeiterBindingSource.DataSource = query;
        }
    }
}
