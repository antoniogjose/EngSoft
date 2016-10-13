using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImoEstudantePLMetroUi
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            Idioma.AjustaCultura(this, "pt");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "pt");
            if (inglesToolStripMenuItem.Checked == true) inglesToolStripMenuItem.Checked = false;
            portuguêsToolStripMenuItem.Enabled = false;
            inglesToolStripMenuItem.Enabled = true;

        }

        private void inguelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "en");
            if (portuguêsToolStripMenuItem.Checked == true) portuguêsToolStripMenuItem.Checked = false;
            inglesToolStripMenuItem.Enabled = false;
            portuguêsToolStripMenuItem.Enabled = true;


        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
