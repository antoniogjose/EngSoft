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
            //foreach (Control ctrls in frm.Controls)
            //{
            //    try
            //    {
            //        ctrls.Text = res_man.GetString(ctrls.Name, cul);
            //    }
            //    catch (Exception e)
            //    {
            //        //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
            //    }
            //}

            foreach (ToolStripMenuItem ctrl in frm.MainMenuStrip.Items)
            {
                try
                {
                    ctrl.Text = res_man.GetString(ctrl.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                }

                foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)ctrl).DropDownItems)
                {
                    try
                    {
                        dropDownItem.Text = res_man.GetString(dropDownItem.Name, cul);
                        //ctrl.Text = res_man.GetString(ctrl.Name, cul);
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
