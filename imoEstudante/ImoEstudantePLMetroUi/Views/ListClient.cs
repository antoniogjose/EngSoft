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
    public partial class ListClient : MetroFramework.Controls.MetroUserControl
    {
        private static ListClient _instance;

        public static ListClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListClient();
                return _instance;
            }
        }
        public ListClient()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClasseStatic.log.GetUsersData();
        }
    }
}
