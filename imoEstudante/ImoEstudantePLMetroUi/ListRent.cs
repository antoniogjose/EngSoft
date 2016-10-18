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
    public partial class ListRent : UserControl
    {
        private static ListRent _instance;

        public static ListRent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListRent();
                return _instance;
            }
        }
        public ListRent()
        {
            InitializeComponent();
        }
    }
}
