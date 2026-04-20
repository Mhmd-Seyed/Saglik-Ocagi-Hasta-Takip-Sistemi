using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjeİlk
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pOLİNİKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoliklinikler fr = new FrmPoliklinikler();

            // İşte MDI Sırrı Burası:
            fr.MdiParent = this; // "Senin baban benim (Ana Menü), benim içimde açıl" diyoruz.

            fr.Show();
        }
    }
}
