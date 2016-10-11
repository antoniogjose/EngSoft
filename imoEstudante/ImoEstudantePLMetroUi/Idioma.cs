using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace ImoEstudantePLMetroUi
{
    class Idioma
    {

        private static void AlteraThreadIdioma(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture, true);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture, true);
        }
        // O método acima altera a cultura da aplicação enquanto o método abaixo varre os controles alterando suas propriedades.
        private static void AlteraCultura(MetroFramework.Forms.MetroForm frm, System.ComponentModel.ComponentResourceManager resx)
        {
            //Altera o nome do form
            frm.Text = resx.GetObject("$this.Text", System.Threading.Thread.CurrentThread.CurrentCulture).ToString();
            //Varre os controles do form aplicando a nova cultura
            foreach (Control ctrl in frm.Controls)
                resx.ApplyResources(ctrl, ctrl.Name, System.Threading.Thread.CurrentThread.CurrentCulture);
        }

        public static void AjustaCultura(MetroFramework.Forms.MetroForm frm, string culture)
        {
            AlteraThreadIdioma(culture);
            System.ComponentModel.ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());
            AlteraCultura(frm, resx);
        }


        //Read more: http://www.linhadecodigo.com.br/artigo/1322/desenvolvendo-aplicacoes-multi-idioma.aspx#ixzz4MoauhPYK


    }
}
