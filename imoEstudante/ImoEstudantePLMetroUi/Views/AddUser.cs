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
    public partial class AddUser : MetroFramework.Controls.MetroUserControl
    {
        private static AddUser _instance;

        public static AddUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddUser();
                return _instance;
            }
        }
        public AddUser()
        {
            InitializeComponent();

            // pais da morada
            List<CRUDImoestudante.PaisRespostaPedido> listObjt = ClasseStatic.log.GetPaises("token").ToList();
            foreach (CRUDImoestudante.PaisRespostaPedido element in listObjt)
                cB_AddUser_Pais.Items.Add(element.Name);

            int index = cB_AddUser_Pais.FindString("Portugal");
            cB_AddUser_Pais.SelectedIndex = index;

            List<CRUDImoestudante.TipoUserRespostaPedido> listObjtipos = ClasseStatic.log.GetUserTypes().ToList();
            foreach (CRUDImoestudante.TipoUserRespostaPedido element in listObjtipos)
                cB_AddUser_UserType.Items.Add(element.Tipo.TrimEnd());

            int index2 = cB_AddUser_UserType.FindString("Agente");
            cB_AddUser_UserType.SelectedIndex = index2;

            cB_AddUser_Genero.SelectedIndex = 1;

        }

        private void bt_AddUser_Addimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAddUser.Load(dlg.FileName);

                }
            }
        }

        private void bt_UserData_Salvar_Click(object sender, EventArgs e)
        {
            UtilizadorRespostaPedido edit = new UtilizadorRespostaPedido();
            edit.TipoUtilizador = cB_AddUser_UserType.SelectedItem.ToString();
            edit.IdUser = 0;
            edit.Nome = tB_AddUser_Nome.Text;
            edit.DataNascimento = Convert.ToDateTime(tB_AddUser_DataNasci.Text);
            edit.PaisOrigen = tB_AddUser_Naci.Text;
            edit.Gen = cB_AddUser_Genero.SelectedItem.ToString();
            edit.IdCurso = 1;

            // preciso validar as duas
            edit.UserName = tb_AddUser_User.Text;
            edit.Password = tb_AddUser_Password.Text;

            // contactos
            edit.Contactos = new ContactoRespostaPedido[3];
            edit.IdCurso = ClasseStatic.us.IdCurso;
            edit.Contactos[0] = new ContactoRespostaPedido();
            edit.Contactos[1] = new ContactoRespostaPedido();
            edit.Contactos[2] = new ContactoRespostaPedido();

            edit.Contactos[0].Tipo = "Telefone";
            edit.Contactos[0].Valor = tB_AddUser_Tel.Text;
            edit.Contactos[0].Descricao = "Pessoal";

            edit.Contactos[1].Tipo = "Email";
            edit.Contactos[1].Valor = tB_AddUserEmail.Text;
            edit.Contactos[1].Descricao = "Pessoal";

            edit.Contactos[2].Tipo = "Urgente";
            edit.Contactos[2].Valor = tb_AddUser_TelefEmerg.Text;
            edit.Contactos[2].Descricao = tb_AddUser_NomeEmerg.Text;


            // morada
            edit.MoradaUtilizador = new MoradaRespostaPedido();
            edit.MoradaUtilizador.IdMorada = 0;
            edit.MoradaUtilizador.Cidade = tb_AddUser_Cidade.Text;
            edit.MoradaUtilizador.CodPostal = Convert.ToInt32(tb_AddUser_CodPostal.Text);
            edit.MoradaUtilizador.Pais = cB_AddUser_Pais.SelectedItem.ToString();

            // não é possivel alterar o tipo de utilizador
            edit.MoradaUtilizador.Rua = tB_AddUser_Rua.Text;

            if (tb_AddUser_Andar.Text != "")
            {

                edit.MoradaUtilizador.DescAndar = tB_AddUser_DescAndar.Text;
                edit.MoradaUtilizador.Andar = Convert.ToInt32(tb_AddUser_Andar.Text);
            }

            

            edit.PaisOrigen = tB_AddUser_Naci.Text;

            if (ClasseStatic.log.AddUser(edit)) MessageBox.Show("O Utilizador foi adicionado");
            else MessageBox.Show("Não foi possivel adicionar utilizador!!");
        }
    }
}
