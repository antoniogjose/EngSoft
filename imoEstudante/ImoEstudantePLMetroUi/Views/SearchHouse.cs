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

            List<CRUDImoestudante.comodidadeRespostaPedido> listObjt = ClasseStatic.log.GetComodData().ToList();
            foreach (CRUDImoestudante.comodidadeRespostaPedido element in listObjt)
                cb_SearchHouse_Comod.Items.Add(element.DescComodidade);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_SearchHouse_Comod_MouseClick(object sender, MouseEventArgs e)
        {

            //lB_SearchHouse_OpPesq.Items.Add(cb_SearchHouse_Comod.SelectedText);

        }



        private void lB_SearchHouse_OpPesq_Click(object sender, EventArgs e)
        {

        }

        private void cb_SearchHouse_Comod_Click(object sender, EventArgs e)
        {

        }

        private void cb_SearchHouse_Comod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cb_SearchHouse_Comod.SelectedIndex;
            Object selectedItem = cb_SearchHouse_Comod.SelectedItem;
            
            if(!lB_SearchHouse_OpPesq.Items.Contains(selectedItem.ToString()))
                lB_SearchHouse_OpPesq.Items.Add(selectedItem.ToString());
        }
    }
}
