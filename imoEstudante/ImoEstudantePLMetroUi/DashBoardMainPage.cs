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
    public partial class DashBoardMainPage : MetroFramework.Controls.MetroUserControl
    {
        private static DashBoardMainPage _instance;

        public static DashBoardMainPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashBoardMainPage();
                return _instance;
            }
        }
        public DashBoardMainPage()
        {
            InitializeComponent();
        }
    }
}
