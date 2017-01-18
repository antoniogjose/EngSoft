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
    public partial class UserData : UserControl
    {
        private static UserData _instance;

        public static UserData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserData();
                return _instance;
            }
        }
        public UserData()
        {
            InitializeComponent();

            if (ClasseStatic.us != null)
            {
                tB_UserData_Nome.Text = ClasseStatic.us.Nome;
                tB_UserData_DataNasci.Text = ClasseStatic.us.DataNascimento.ToShortDateString();
                tB_UserData_Naci.Text = ClasseStatic.us.PaisOrigen;
                tB_UserData_Genero.Text = ClasseStatic.us.Gen;
                tB_UserData_Tel.Text = ClasseStatic.us.Contactos.ToList().Where(x => x.Tipo == "Telefone" && x.Nivel == 1).First().Valor.ToString();
                tB_UserData_Email.Text = ClasseStatic.us.Contactos.ToList().Where(x => x.Tipo == "Email" && x.Nivel == 1).First().Valor.ToString();
                //rB_UserData_Morada.Text = ClasseStatic.us.MoradaUtilizador.Rua.TrimEnd() + " Nº " + ClasseStatic.us.MoradaUtilizador.Numero + " " 
                //    + ((ClasseStatic.us.MoradaUtilizador.Andar == 0)?"": ClasseStatic.us.MoradaUtilizador.Andar.ToString() + " " + ClasseStatic.us.MoradaUtilizador.DescAndar.TrimEnd()).ToString() + 
                //    "\n" +
                //    ClasseStatic.us.MoradaUtilizador.CodPostal + " " +  + ", " + 


                tB_UserData_Rua.Text = ClasseStatic.us.MoradaUtilizador.Rua.TrimEnd();
                //tb.Text = ClasseStatic.us.MoradaUtilizador.Cidade.TrimEnd();

                if (ClasseStatic.us.MoradaUtilizador.DescAndar != null)
                {
                    tb_UserData_DescAndar.Text = ClasseStatic.us.MoradaUtilizador.DescAndar;
                    tb_UserData_Andar.Text = ClasseStatic.us.MoradaUtilizador.Andar.ToString();
                }

                tb_UserData_Cidade.Text = ClasseStatic.us.MoradaUtilizador.Cidade;

                tb_UserData_UserType.Text = ClasseStatic.us.TipoUtilizador;
                tb_UserData_User.Text = ClasseStatic.us.UserName;
                tb_UserData_CodPostal.Text = ClasseStatic.us.MoradaUtilizador.CodPostal.ToString();

                List <CRUDImoestudante.PaisRespostaPedido> listObjt = ClasseStatic.log.GetPaises("token").ToList();
                foreach (CRUDImoestudante.PaisRespostaPedido element in listObjt)
                    cB_UserData_Pais.Items.Add(element.Name);

                int index = cB_UserData_Pais.FindString(ClasseStatic.us.MoradaUtilizador.Pais.TrimEnd());
                cB_UserData_Pais.SelectedIndex = index;




            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
