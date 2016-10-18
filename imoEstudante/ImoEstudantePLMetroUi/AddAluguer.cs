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
    public partial class AddAluguer : UserControl
    {
        private static AddAluguer _instance;

        public static AddAluguer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddAluguer();
                return _instance;
            }
        }
        public AddAluguer()
        {
            InitializeComponent();
        }
    }
}
