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
    public partial class EditHouse : MetroFramework.Controls.MetroUserControl
    {
        private static EditHouse _instance;

        public static EditHouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditHouse();
                return _instance;
            }
        }
        public EditHouse()
        {
            InitializeComponent();
        }
    }
}
