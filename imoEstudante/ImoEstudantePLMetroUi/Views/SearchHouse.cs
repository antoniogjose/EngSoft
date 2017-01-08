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
    public partial class SearchHouse : MetroFramework.Controls.MetroUserControl
    {
        private static SearchHouse _instance;

        public static SearchHouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchHouse();
                return _instance;
            }
        }
        public SearchHouse()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
