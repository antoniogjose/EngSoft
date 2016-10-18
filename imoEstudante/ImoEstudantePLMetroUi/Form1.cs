using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ImoEstudantePLMetroUi
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            Idioma.AjustaCultura(this, "pt");
            InitializeComponent();
            if (!panel.Controls.Contains(DashBoardMainPage.Instance))
            {
                panel.Controls.Add(DashBoardMainPage.Instance);
                DashBoardMainPage.Instance.Dock = DockStyle.Fill;
                DashBoardMainPage.Instance.BringToFront();
            }
            else
                DashBoardMainPage.Instance.BringToFront();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(EditUser.Instance))
            {
                panel.Controls.Add(EditUser.Instance);
                EditUser.Instance.Dock = DockStyle.Fill;
                EditUser.Instance.BringToFront();
            }
            else
                EditUser.Instance.BringToFront();
        }

        private void adicionarUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddClient.Instance))
            {
                panel.Controls.Add(AddClient.Instance);
                AddClient.Instance.Dock = DockStyle.Fill;
                AddClient.Instance.BringToFront();
            }
            else
                AddClient.Instance.BringToFront();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(SearchRent.Instance))
            {
                panel.Controls.Add(SearchRent.Instance);
                SearchRent.Instance.Dock = DockStyle.Fill;
                SearchRent.Instance.BringToFront();
            }
            else
                SearchRent.Instance.BringToFront();

        }

        private void btAddRent_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddRent.Instance))
            {
                panel.Controls.Add(AddRent.Instance);
                AddRent.Instance.Dock = DockStyle.Fill;
                AddRent.Instance.BringToFront();
            }
            else
                AddRent.Instance.BringToFront();

        }

        private void btEditRent_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(EditRent.Instance))
            {
                panel.Controls.Add(EditRent.Instance);
                EditRent.Instance.Dock = DockStyle.Fill;
                EditRent.Instance.BringToFront();
            }
            else
                EditRent.Instance.BringToFront();

        }
    }
}
