namespace ImoEstudantePLMetroUi
{
    partial class EditClient
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
            this.editClient_label1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.addRent_tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panelDashBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.Controls.Add(this.editClient_label1);
            this.panelDashBoard.Controls.Add(this.panel1);
            this.panelDashBoard.HorizontalScrollbarBarColor = true;
            this.panelDashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.HorizontalScrollbarSize = 10;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(848, 553);
            this.panelDashBoard.TabIndex = 4;
            this.panelDashBoard.VerticalScrollbarBarColor = true;
            this.panelDashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.VerticalScrollbarSize = 10;
            // 
            // editClient_label1
            // 
            this.editClient_label1.AutoSize = true;
            this.editClient_label1.BackColor = System.Drawing.Color.DimGray;
            this.editClient_label1.Location = new System.Drawing.Point(4, 22);
            this.editClient_label1.Name = "editClient_label1";
            this.editClient_label1.Size = new System.Drawing.Size(205, 19);
            this.editClient_label1.TabIndex = 3;
            this.editClient_label1.Text = "ImoEstudante » Edição de Cliente";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 506);
            this.panel1.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.addRent_tabPage1);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(848, 506);
            this.metroTabControl1.TabIndex = 2;
            // 
            // addRent_tabPage1
            // 
            this.addRent_tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRent_tabPage1.HorizontalScrollbarBarColor = true;
            this.addRent_tabPage1.Location = new System.Drawing.Point(4, 35);
            this.addRent_tabPage1.Name = "addRent_tabPage1";
            this.addRent_tabPage1.Size = new System.Drawing.Size(840, 467);
            this.addRent_tabPage1.TabIndex = 0;
            this.addRent_tabPage1.Text = "Dados do Aluguer";
            this.addRent_tabPage1.VerticalScrollbarBarColor = true;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelDashBoard);
            this.Name = "EditClient";
            this.Size = new System.Drawing.Size(848, 553);
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDashBoard;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel editClient_label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage addRent_tabPage1;
    }
}
