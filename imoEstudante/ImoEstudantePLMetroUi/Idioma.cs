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
            foreach (ToolStripMenuItem ctrlTool in frm.MainMenuStrip.Items)
            {
                try
                {
                    ctrlTool.Text = res_man.GetString(ctrlTool.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error.", e);
                }

                foreach (ToolStripItem ctrlDrop in ((ToolStripDropDownItem)ctrlTool).DropDownItems)
                {
                    try
                    {
                        ctrlDrop.Text = res_man.GetString(ctrlDrop.Name, cul);
                    }
                    catch (Exception e)
                    {
                        //throw new Exception("Error.", e);
                    }
                }
            }
        }


        public static void switchLanguage(MetroFramework.Controls.MetroPanel panel, CultureInfo cul, ResourceManager res_man)
        {
            foreach (Control ctrls001 in panel.Controls)
            {
                try
                {
                    ctrls001.Text = res_man.GetString(ctrls001.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error.", e);
                }

                foreach (Control ctrls002 in ctrls001.Controls)
                {
                    try
                    {
                        ctrls002.Text = res_man.GetString(ctrls002.Name, cul);
                    }
                    catch (Exception e)
                    {
                        //throw new Exception("Error.", e);
                    }
                    
                    foreach (Control ctrls003 in ctrls002.Controls)
                    {
                        try
                        {
                            ctrls003.Text = res_man.GetString(ctrls003.Name, cul);
                        }
                        catch (Exception e)
                        {
                            //throw new Exception("Error.", e);
                        }
                        
                        foreach (Control ctrls004 in ctrls003.Controls)
                        {
                            try
                            {
                                ctrls004.Text = res_man.GetString(ctrls004.Name, cul);
                            }
                            catch (Exception e)
                            {
                                //throw new Exception("Error.", e);
                            }
                            
                            foreach (Control ctrls005 in ctrls004.Controls)
                            {
                                try
                                {
                                    ctrls005.Text = res_man.GetString(ctrls005.Name, cul);
                                }
                                catch (Exception e)
                                {
                                    //throw new Exception("Error.", e);
                                }

                                foreach (Control ctrls006 in ctrls005.Controls)
                                {
                                    try
                                    {
                                        ctrls006.Text = res_man.GetString(ctrls006.Name, cul);
                                    }
                                    catch (Exception e)
                                    {
                                        //throw new Exception("Error.", e);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
