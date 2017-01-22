using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImoEstudantePLMetroUi.Views
{
    public partial class AddHouseImages : UserControl
    {
        private static AddHouseImages _instance;

        public static AddHouseImages Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddHouseImages();
                return _instance;
            }
        }
        public AddHouseImages()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void bT_AddHouseImages_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione por favor";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg| JPEG |*.jpeg|GIF|*.gif|PNG|.*png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int x = 40;
                int y = 40;
                int maxHeight = -1;
                foreach (string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x < this.ClientSize.Width - 200)
                    {
                        x = 40;
                        y += maxHeight + 20;
                    }
                    this.flowLayoutPanel1.Controls.Add(pic);
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
