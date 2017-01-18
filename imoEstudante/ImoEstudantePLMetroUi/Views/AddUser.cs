using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImoEstudantePLMetroUi
{
    public partial class AddUser : MetroFramework.Controls.MetroUserControl
    {
        private static AddUser _instance;

        public static AddUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddUser();
                return _instance;
            }
        }
        public AddUser()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //PictureBox PictureBox1 = new PictureBox();

                    pictureBoxAddUser.Image = new Bitmap(dlg.FileName);

                    // Add the new control to its parent's controls collection
                    this.Controls.Add(pictureBoxAddUser);
                }
            }
        }
    }
}
