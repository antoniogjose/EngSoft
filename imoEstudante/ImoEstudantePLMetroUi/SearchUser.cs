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
    public partial class SearchUser : UserControl
    {
        private static SearchUser _instance;

        public static SearchUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchUser();
                return _instance;
            }
        }
        public SearchUser()
        {
            InitializeComponent();
        }
    }
}
