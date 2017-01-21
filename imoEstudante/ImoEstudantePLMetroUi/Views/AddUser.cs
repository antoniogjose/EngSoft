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
            edit.TipoUtilizador = ClasseStatic.us.TipoUtilizador;
            edit.IdUser = 0;
            edit.Nome = tB_AddUser_Nome.Text;
            edit.DataNascimento = Convert.ToDateTime(tB_AddUser_DataNasci.Text);
            edit.PaisOrigen = tB_AddUser_Naci.Text;
            edit.Gen = tB_AddUser_Genero.Text;

            // preciso validar as duas
            edit.Password = tb_AddUser_Password.Text;

            edit.Contactos = new ContactoRespostaPedido[3];
            edit.IdCurso = ClasseStatic.us.IdCurso;

            edit.Contactos[0].Tipo = "Telefone";
            edit.Contactos[0].Valor = tB_AddUser_Tel.Text;



            edit.Contactos.ToList().Where(x => x.Tipo == "Telefone" && x.Nivel == 1).First().Valor = tB_AddUser_Tel.Text;
            edit.Contactos.ToList().Where(x => x.Tipo == "Telefone" && x.Nivel == 1).First().Descricao = tB_AddUser_Tel.Text;
            edit.Contactos.ToList().Where(x => x.Tipo == "Email" && x.Nivel == 1).First().Valor = tB_AddUserEmail.Text;
            edit.Contactos.ToList().Where(x => x.Tipo == "Email" && x.Nivel == 1).First().Descricao = "Pessoal";
            edit.Contactos.ToList().Where(x => x.Tipo == "Urgente" && x.Nivel == 1).First().Valor = tb_AddUser_TelefEmerg.Text;
            edit.Contactos.ToList().Where(x => x.Tipo == "Urgente" && x.Nivel == 1).First().Descricao = tb_AddUser_NomeEmerg.Text;


            // morada
            edit.MoradaUtilizador = new MoradaRespostaPedido();
            edit.MoradaUtilizador.IdMorada = ClasseStatic.us.MoradaUtilizador.IdMorada;
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

            edit.UserName = tb_AddUser_User.Text;

            //cB_UserData_Pais.DisplayMember = "CountryName";
            //DataRow selectedDataRow = ((DataRowView)cB_UserData_Pais.SelectedItem).Row;

            edit.PaisOrigen = tB_AddUser_Naci.Text;

            if (ClasseStatic.log.EditUser(edit)) MessageBox.Show("Dados Alterados");
            else MessageBox.Show("Não foi possivel efectuar a operação pretendida!!");
        }
    }
}
