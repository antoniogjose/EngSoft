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
        public AddHouseImages()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione por favor";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg| JPEG |*.jpeg|GIF|*.gif|PNG|.*png";
            DialogResult dr = ofd.ShowDialog();
            if(dr==System.Windows.Forms.DialogResult.OK)
            {
                string [] files = ofd.FileNames;
                int x = 20;
                int y = 20;
                int maxHeight = -1;
                foreach (string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.CenterImage;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if(x< this.ClientSize.Width -100)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.panelImage.Controls.Add(pic);
                }
            }
        }
    }
}
