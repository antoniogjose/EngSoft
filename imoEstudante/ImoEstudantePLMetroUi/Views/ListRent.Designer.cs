namespace ImoEstudantePLMetroUi
{
    partial class ListRent
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
            this.listRent_label1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.Controls.Add(this.listRent_label1);
            this.panelDashBoard.Controls.Add(this.panel1);
            this.panelDashBoard.HorizontalScrollbarBarColor = true;
            this.panelDashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.HorizontalScrollbarSize = 12;
            this.panelDashBoard.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(1005, 610);
            this.panelDashBoard.TabIndex = 5;
            this.panelDashBoard.VerticalScrollbarBarColor = true;
            this.panelDashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashBoard.VerticalScrollbarSize = 13;
            // 
            // listRent_label1
            // 
            this.listRent_label1.AutoSize = true;
            this.listRent_label1.BackColor = System.Drawing.Color.DimGray;
            this.listRent_label1.Location = new System.Drawing.Point(5, 27);
            this.listRent_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listRent_label1.Name = "listRent_label1";
            this.listRent_label1.Size = new System.Drawing.Size(222, 20);
            this.listRent_label1.TabIndex = 3;
            this.listRent_label1.Text = "ImoEstudante » Lista de Alugueres";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 553);
            this.panel1.TabIndex = 2;
            // 
            // ListRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDashBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListRent";
            this.Size = new System.Drawing.Size(1005, 610);
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDashBoard;
        private MetroFramework.Controls.MetroLabel listRent_label1;
        private System.Windows.Forms.Panel panel1;
    }
}
