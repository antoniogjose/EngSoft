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
    public partial class AddHouse : MetroFramework.Controls.MetroUserControl
    {
        private static AddHouse _instance;

        public static AddHouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddHouse();
                return _instance;
            }
        }
        public AddHouse()
        {
            InitializeComponent();
        }
    }
}
