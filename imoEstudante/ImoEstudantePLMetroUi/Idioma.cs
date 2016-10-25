using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

using System.Globalization;
using System.Resources;

namespace ImoEstudantePLMetroUi
{
    class Idioma : Exception
    {
        public static void switchLanguage(MetroFramework.Forms.MetroForm frm, CultureInfo cul, ResourceManager res_man)
        {
            //Altera o nome do form
            //frm.Text = resx.GetObject("$this.Text", System.Threading.Thread.CurrentThread.CurrentCulture).ToString();
            //Varre os controles do form aplicando a nova cultura
            //foreach (Control ctrl in frm.Controls)
            //{
            //    if (string.IsNullOrEmpty(ctrl.Name) == false)
            //    {
            //        var result = MessageBox.Show(ctrl.Name);

            //        //if (string.IsNullOrEmpty(ctrl.Text = res_man.GetString(ctrl.Name, cul)) == false)
            //        //{
            //        ctrl.Text = res_man.GetString(ctrl.Name, cul);
            //        // }
            //    }
            //}

            foreach (ToolStripMenuItem ctrl in frm.MainMenuStrip.Items)
            {
                if (ctrl is ToolStripMenuItem)
                {
                    try
                    {
                        ctrl.Text = res_man.GetString(ctrl.Name, cul);
                    }
                    catch (Exception e)
                    {
                        //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                    }
                }
            }

        }
    }
}
