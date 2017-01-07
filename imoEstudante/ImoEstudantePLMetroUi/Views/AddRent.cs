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
    public partial class AddRent : MetroFramework.Controls.MetroUserControl
    {
        private static AddRent _instance;

        public static AddRent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddRent();
                return _instance;
            }
        }
        public AddRent()
        {
            InitializeComponent();
        }
    }
}
