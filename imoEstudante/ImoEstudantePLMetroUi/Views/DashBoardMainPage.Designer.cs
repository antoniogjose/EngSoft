namespace ImoEstudantePLMetroUi
{
    partial class DashBoardMainPage
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
            this.dashBoard_label1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashBoard_tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.dashBoard_tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.dashBoard_tabControl1.SuspendLayout();
            this.dashBoard_tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoard_label1
            // 
            this.dashBoard_label1.AutoSize = true;
            this.dashBoard_label1.BackColor = System.Drawing.Color.DimGray;
            this.dashBoard_label1.Location = new System.Drawing.Point(4, 22);
            this.dashBoard_label1.Name = "dashBoard_label1";
            this.dashBoard_label1.Size = new System.Drawing.Size(93, 20);
            this.dashBoard_label1.TabIndex = 4;
            this.dashBoard_label1.Text = "ImoEstudante";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dashBoard_tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 449);
            this.panel1.TabIndex = 5;
            // 
            // dashBoard_tabControl1
            // 
            this.dashBoard_tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashBoard_tabControl1.Controls.Add(this.dashBoard_tabPage1);
            this.dashBoard_tabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.dashBoard_tabControl1.Location = new System.Drawing.Point(0, 0);
            this.dashBoard_tabControl1.Name = "dashBoard_tabControl1";
            this.dashBoard_tabControl1.SelectedIndex = 0;
            this.dashBoard_tabControl1.Size = new System.Drawing.Size(754, 449);
            this.dashBoard_tabControl1.TabIndex = 2;
            // 
            // dashBoard_tabPage1
            // 
            this.dashBoard_tabPage1.Controls.Add(this.pieChart3);
            this.dashBoard_tabPage1.Controls.Add(this.pieChart2);
            this.dashBoard_tabPage1.Controls.Add(this.pieChart1);
            this.dashBoard_tabPage1.Controls.Add(this.cartesianChart1);
            this.dashBoard_tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard_tabPage1.HorizontalScrollbarBarColor = true;
            this.dashBoard_tabPage1.Location = new System.Drawing.Point(4, 39);
            this.dashBoard_tabPage1.Name = "dashBoard_tabPage1";
            this.dashBoard_tabPage1.Size = new System.Drawing.Size(746, 406);
            this.dashBoard_tabPage1.TabIndex = 0;
            this.dashBoard_tabPage1.Text = "Dados de Negócio";
            this.dashBoard_tabPage1.VerticalScrollbarBarColor = true;
            // 
            // pieChart3
            // 
            this.pieChart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart3.BackColor = System.Drawing.Color.White;
            this.pieChart3.Location = new System.Drawing.Point(543, 247);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(200, 160);
            this.pieChart3.TabIndex = 3;
            this.pieChart3.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart2.BackColor = System.Drawing.Color.White;
            this.pieChart2.Location = new System.Drawing.Point(288, 250);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(200, 160);
            this.pieChart2.TabIndex = 3;
            this.pieChart2.Text = "pieChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.BackColor = System.Drawing.Color.White;
            this.pieChart1.Location = new System.Drawing.Point(20, 247);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(200, 160);
            this.pieChart1.TabIndex = 3;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.BackColor = System.Drawing.Color.White;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 17);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(743, 224);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // DashBoardMainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashBoard_label1);
            this.Name = "DashBoardMainPage";
            this.Size = new System.Drawing.Size(754, 496);
            this.panel1.ResumeLayout(false);
            this.dashBoard_tabControl1.ResumeLayout(false);
            this.dashBoard_tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel dashBoard_label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl dashBoard_tabControl1;
        private MetroFramework.Controls.MetroTabPage dashBoard_tabPage1;
        private LiveCharts.WinForms.PieChart pieChart3;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
