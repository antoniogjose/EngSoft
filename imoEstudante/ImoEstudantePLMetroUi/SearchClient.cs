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
    public partial class SearchClient : MetroFramework.Controls.MetroUserControl
    {
        private static SearchClient _instance;

        public static SearchClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchClient();
                return _instance;
            }
        }
        public SearchClient()
        {
            InitializeComponent();
        }
    }
}
