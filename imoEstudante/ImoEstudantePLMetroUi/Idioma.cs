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
            foreach (Control ctrls in frm.Controls)
            {
                try
                {
                    //DialogResult result = MessageBox.Show(ctrls.Name);

                    ctrls.Text = res_man.GetString(ctrls.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                }                
            }

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
                        //DialogResult result = MessageBox.Show(dropDownItem.Name);
                        dropDownItem.Text = res_man.GetString(dropDownItem.Name, cul);
                    }
                    catch (Exception e)
                    {
                        //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                    }                    
                }
            }
        }


        /*
        public static void switchLanguage2(DashBoardMainPage frm, CultureInfo cul, ResourceManager res_man)
        {
            foreach (Control ctrls in frm.Controls)
            {
                try
                {
                    //DialogResult result = MessageBox.Show(ctrls.Name);

                    ctrls.Text = res_man.GetString(ctrls.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                }
            }
            
        }
        */
        
        public static void switchLanguage(MetroFramework.Controls.MetroPanel frms, CultureInfo cul, ResourceManager res_man)
        {
            foreach (Control ctrls in frms.Controls)
            {
                try
                {
                    //DialogResult result = MessageBox.Show(ctrls.Name);
                    ctrls.Text = res_man.GetString(ctrls.Name, cul);
                }
                catch (Exception e)
                {
                    //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                }

                foreach (Control drops in ctrls.Controls)
                {
                    try
                    {
                        //DialogResult result = MessageBox.Show(drops.Name);
                        drops.Text = res_man.GetString(drops.Name, cul);
                        //ctrl.Text = res_man.GetString(ctrl.Name, cul);
                    }
                    catch (Exception e)
                    {
                        //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                    }


                    foreach (Control label in drops.Controls)
                    {
                        try
                        {
                            //DialogResult result = MessageBox.Show(label.Name);
                            label.Text = res_man.GetString(label.Name, cul);
                        }
                        catch (Exception e)
                        {
                            //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                        }


                        foreach (Control lab in label.Controls)
                        {
                            try
                            {
                                //DialogResult result = MessageBox.Show(lab.Name);
                                lab.Text = res_man.GetString(lab.Name, cul);
                            }
                            catch (Exception e)
                            {
                                //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                            }


                            foreach (Control labi in lab.Controls)
                            {
                                try
                                {
                                    //DialogResult result = MessageBox.Show(labi.Name);
                                    labi.Text = res_man.GetString(labi.Name, cul);
                                }
                                catch (Exception e)
                                {
                                    //throw new Exception("Error in CatchInner caused by calling the ThrowInner method.", e);
                                }


                                foreach (Control lab1 in labi.Controls)
                                {
                                    try
                                    {
                                        //DialogResult result = MessageBox.Show(lab1.Name);
                                        lab1.Text = res_man.GetString(lab1.Name, cul);
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
            }
        }
    }
}
