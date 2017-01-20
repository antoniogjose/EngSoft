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

        private void bt_AddUser_Addimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxUserData.Load(dlg.FileName);

                }
            }
        }


    }
}
