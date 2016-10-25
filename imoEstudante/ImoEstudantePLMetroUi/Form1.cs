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

using System.Globalization;
using System.Resources;

namespace ImoEstudantePLMetroUi
{
    public partial class Form1 : MetroForm
    {
        ResourceManager res_man;    // Recursos
        CultureInfo cul;            // Cultura

        public Form1()
        {
            // Idioma.AjustaCultura(this, "pt");
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
            // inicia em portugues
            //portuguêsToolStripMenuItem.Checked = true;
            //inglesToolStripMenuItem.Checked = false;

            res_man = new ResourceManager("ImoEstudantePLMetroUi.Resources.Res", typeof(Form1).Assembly);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inglesToolStripMenuItem.Checked == true)
            {
                inglesToolStripMenuItem.Checked = false;
                portuguêsToolStripMenuItem.Checked = true;

                switch_language();
            }
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (portuguêsToolStripMenuItem.Checked == true)
            {
                portuguêsToolStripMenuItem.Checked = false;
                inglesToolStripMenuItem.Enabled = true;

                switch_language();
            }

        }


        //Function for switch language
        private void switch_language()
        {            
            if (inglesToolStripMenuItem.Checked == true)
            {
                // cultura: inglês
                cul = CultureInfo.CreateSpecificCulture("en");
            }
            else // (portuguêsToolStripMenuItem.Checked == true)
            {
                // cultura base: português
                cul = CultureInfo.CreateSpecificCulture("pt");
            }

            // mudar idioma
            Idioma.switchLanguage(this, cul, res_man);

            //foreach (ToolStripMenuItem ctrlsss in this.menuStrip1.Items)
            //{
            //    if (ctrlsss is ToolStripMenuItem)
            //    {
            //        var result2 = MessageBox.Show(ctrlsss.Name);
            //    }
            //    //else
            //    //{
            //    //    var result3 = MessageBox.Show(ctrlsss.Name);
            //    //}
            //}

            /*exit_text_string = res_man.GetString("exit_text_string", cul);
            exit_caption_string = res_man.GetString("exit_caption_string", cul);*/


            //
            //this.Text = res_man.GetString("Form1_text", cul);

            //menuToolStripMenuItem.Text = res_man.GetString(menuToolStripMenuItem.Name, cul);

            //foreach(Control x in this.Controls)
            //{
            //    if (string.IsNullOrEmpty(res_man.GetString(x.Name,cul)))
            //    {
            //        x.Text = res_man.GetString(x.Name, cul);
            //    }
            //    /*
            //    if (x.Name.Equals("menuToolStripMenuItem"))
            //    {
            //        x.Text = res_man.GetString("menuToolStripMenuItem", cul);
            //    }*/               
            //}

            /*
            fileToolStripMenuItem.Text = res_man.GetString("File_menu", cul);
            exitToolStripMenuItem.Text = res_man.GetString("Exit_menu", cul);

            languageToolStripMenuItem.Text = res_man.GetString("Language_menu", cul);
            vietnameseToolStripMenuItem.Text = res_man.GetString("Vietnamese_menu", cul);
            englishToolStripMenuItem.Text = res_man.GetString("English_menu", cul);

            textBox1.Text = res_man.GetString("Textbox_text", cul);*/
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
            if (!panel.Controls.Contains(SearchUser.Instance))
            {
                panel.Controls.Add(SearchUser.Instance);
                SearchUser.Instance.Dock = DockStyle.Fill;
                SearchUser.Instance.BringToFront();
            }
            else
                SearchUser.Instance.BringToFront();
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

        private void btAddHouse_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddHouse.Instance))
            {
                panel.Controls.Add(AddHouse.Instance);
                AddHouse.Instance.Dock = DockStyle.Fill;
                AddHouse.Instance.BringToFront();
            }
            else
                AddHouse.Instance.BringToFront();
        }

        private void btEditHouse_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(EditHouse.Instance))
            {
                panel.Controls.Add(EditHouse.Instance);
                EditHouse.Instance.Dock = DockStyle.Fill;
                EditHouse.Instance.BringToFront();
            }
            else
                EditHouse.Instance.BringToFront();
        }

        private void btListHouse_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ListHouse.Instance))
            {
                panel.Controls.Add(ListHouse.Instance);
                ListHouse.Instance.Dock = DockStyle.Fill;
                ListHouse.Instance.BringToFront();
            }
            else
                ListHouse.Instance.BringToFront();
        }

        private void btSearchClient_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(SearchClient.Instance))
            {
                panel.Controls.Add(SearchClient.Instance);
                SearchClient.Instance.Dock = DockStyle.Fill;
                SearchClient.Instance.BringToFront();
            }
            else
                SearchClient.Instance.BringToFront();
        }

        private void btAddClient_Click(object sender, EventArgs e)
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

        private void btEditClient_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(EditClient.Instance))
            {
                panel.Controls.Add(EditClient.Instance);
                EditClient.Instance.Dock = DockStyle.Fill;
                EditClient.Instance.BringToFront();
            }
            else
                EditClient.Instance.BringToFront();
        }

        private void btListClient_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ListClient.Instance))
            {
                panel.Controls.Add(ListClient.Instance);
                ListClient.Instance.Dock = DockStyle.Fill;
                ListClient.Instance.BringToFront();
            }
            else
                ListClient.Instance.BringToFront();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ListRent.Instance))
            {
                panel.Controls.Add(ListRent.Instance);
                ListRent.Instance.Dock = DockStyle.Fill;
                ListRent.Instance.BringToFront();
            }
            else
                ListRent.Instance.BringToFront();
        }

        private void btSearchHouse_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(SearchHouse.Instance))
            {
                panel.Controls.Add(SearchHouse.Instance);
                SearchHouse.Instance.Dock = DockStyle.Fill;
                SearchHouse.Instance.BringToFront();
            }
            else
                SearchHouse.Instance.BringToFront();
        }

        private void adicionarUtilizadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddUser.Instance))
            {
                panel.Controls.Add(AddUser.Instance);
                AddUser.Instance.Dock = DockStyle.Fill;
                AddUser.Instance.BringToFront();
            }
            else
                AddUser.Instance.BringToFront();
        }
    }
}
