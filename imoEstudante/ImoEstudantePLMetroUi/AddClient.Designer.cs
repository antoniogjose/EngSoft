namespace ImoEstudantePLMetroUi
{
    partial class AddClient
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Controls.Add(this.metroLabel1);
            this.panelDashBoard.Controls.Add(this.panel1);
            this.panelDashBoard.HorizontalScrollbarBarColor = true;
            this.panelDashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.HorizontalScrollbarSize = 10;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(805, 460);
            this.panelDashBoard.TabIndex = 5;
            this.panelDashBoard.VerticalScrollbarBarColor = true;
            this.panelDashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(4, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Adicionar de Cliente";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 413);
            this.panel1.TabIndex = 2;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelDashBoard);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(830, 460);
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDashBoard;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
