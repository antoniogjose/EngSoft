using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImoEstudantePLMetroUi.Resources;
using ImoEstudantePLMetroUi.CRUDImoestudante;

namespace ImoEstudantePLMetroUi
{
    public partial class ListHouse : MetroFramework.Controls.MetroUserControl
    {
        private static ListHouse _instance;

        public static ListHouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListHouse();
                return _instance;
            }
        }
        public ListHouse()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClasseStatic.log.GetHouseData();
        }
    }
}
