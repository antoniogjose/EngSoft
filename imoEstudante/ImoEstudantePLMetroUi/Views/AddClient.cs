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
    public partial class AddClient : MetroFramework.Controls.MetroUserControl
    {
        private static AddClient _instance;

        public static AddClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddClient();
                return _instance;
            }
        }
        public AddClient()
        {
            InitializeComponent();
        }
    }
}
