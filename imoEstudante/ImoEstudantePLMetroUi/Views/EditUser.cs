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
    public partial class EditUser : MetroFramework.Controls.MetroUserControl
    {
        private static EditUser _instance;

        public static EditUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditUser();
                return _instance;
            }
        }
        public EditUser()
        {
            InitializeComponent();

            if(ClasseStatic.us != null)
            {
                tB_editUser_Nome.Text = ClasseStatic.us.Nome;
                tB_editUser_DataNasci.Text = ClasseStatic.us.DataNascimento.ToShortDateString();
                tB_editUser_Naci.Text = ClasseStatic.us.PaisOrigen;
                tB_editUser_Genero.Text = ClasseStatic.us.Gen;
                tB_editUser_Tel.Text = ClasseStatic.us.Contactos.ToList().Where(x => x.Tipo == "Telefone" && x.Nivel == 1).First().Valor.ToString();
                tB_editUser_Email.Text = ClasseStatic.us.Contactos.ToList().Where(x => x.Tipo == "Email" && x.Nivel == 1).First().Valor.ToString();
                //rB_editUser_Morada.Text = ClasseStatic.us.MoradaUtilizador.Rua.TrimEnd() + " Nº " + ClasseStatic.us.MoradaUtilizador.Numero + " " 
                //    + ((ClasseStatic.us.MoradaUtilizador.Andar == 0)?"": ClasseStatic.us.MoradaUtilizador.Andar.ToString() + " " + ClasseStatic.us.MoradaUtilizador.DescAndar.TrimEnd()).ToString() + 
                //    "\n" +
                //    ClasseStatic.us.MoradaUtilizador.CodPostal + " " +  + ", " + 


                tB_editUser_Rua.Text = ClasseStatic.us.MoradaUtilizador.Rua.TrimEnd();
                //tb.Text = ClasseStatic.us.MoradaUtilizador.Cidade.TrimEnd();

                List<CRUDImoestudante.PaisRespostaPedido> listObjt = ClasseStatic.log.GetPaises("token").ToList();
                foreach (CRUDImoestudante.PaisRespostaPedido element in listObjt)
                    cB_editUser_Pais.Items.Add(element.Name);

                int index = cB_editUser_Pais.FindString(ClasseStatic.us.MoradaUtilizador.Pais.TrimEnd());
                cB_editUser_Pais.SelectedIndex = index;




            }
        }
    }
}
