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
    public partial class EditUser : MetroFramework.Controls.MetroUserControl
    {
        private static EditUser _instance;

        public static EditUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditUser();
                return _instance;
            }
        }
        public EditUser()
        {
            InitializeComponent();
        }
    }
}
