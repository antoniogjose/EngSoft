﻿namespace ImoEstudantePLMetroUi
{
    partial class EditRent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDashBoard = new MetroFramework.Controls.MetroPanel();
            this.editRent_label1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.Controls.Add(this.editRent_label1);
            this.panelDashBoard.Controls.Add(this.panel1);
            this.panelDashBoard.HorizontalScrollbarBarColor = true;
            this.panelDashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.HorizontalScrollbarSize = 10;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(848, 553);
            this.panelDashBoard.TabIndex = 5;
            this.panelDashBoard.VerticalScrollbarBarColor = true;
            this.panelDashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.VerticalScrollbarSize = 10;
            // 
            // editRent_label1
            // 
            this.editRent_label1.AutoSize = true;
            this.editRent_label1.BackColor = System.Drawing.Color.DimGray;
            this.editRent_label1.Location = new System.Drawing.Point(4, 22);
            this.editRent_label1.Name = "editRent_label1";
            this.editRent_label1.Size = new System.Drawing.Size(211, 19);
            this.editRent_label1.TabIndex = 3;
            this.editRent_label1.Text = "ImoEstudante » Edição de Aluguer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 506);
            this.panel1.TabIndex = 2;
            // 
            // EditRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDashBoard);
            this.Name = "EditRent";
            this.Size = new System.Drawing.Size(848, 553);
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDashBoard;
        private MetroFramework.Controls.MetroLabel editRent_label1;
        private System.Windows.Forms.Panel panel1;
    }
}
