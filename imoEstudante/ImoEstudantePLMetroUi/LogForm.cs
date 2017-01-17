using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ImoEstudantePLMetroUi.CRUDImoestudante;
using ImoEstudantePLMetroUi.Resources;
using System.ServiceModel.Security;

namespace ImoEstudantePLMetroUi
{
    public partial class LogForm : MetroForm
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseStatic.log = new Service1Client();

                ClasseStatic.us = new UtilizadorRespostaPedido();


                string userName = tbUserName.Text;
                string password = TbPassword.Text;

                ClasseStatic.log.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                ClasseStatic.log.ClientCredentials.UserName.UserName = userName;
                ClasseStatic.log.ClientCredentials.UserName.Password = password;

                ClasseStatic.us = ClasseStatic.log.GetUserType(userName);
                MessageBox.Show("Inicio de Sessão por: " + ClasseStatic.us.Nome);


                //ClasseStatic.log.GetUserTypeCompleted += Log_GetUserTypeCompleted;
                //ClasseStatic.log.GetUserTypeAsync(userName);

                Form1 prg = new Form1();
                prg.Show();
                this.Hide();


            }
            catch //(Exception ex)
            {
                // MessageBox.Show("Erro : " + ex.ToString());
                MessageBox.Show("Acesso Negado!!");
                btnLogin.DialogResult = DialogResult.None;

            }
        }

        //private void Log_GetUserTypeCompleted(object sender, GetUserTypeCompletedEventArgs e)
        //{
        //    ClasseStatic.us = e.Result;
        //    MessageBox.Show("Inicio de Sessão por: " + ClasseStatic.us.Nome);


        //}

        private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

    }
}

