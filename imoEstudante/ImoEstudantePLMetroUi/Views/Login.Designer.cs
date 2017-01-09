namespace ImoEstudantePLMetroUi
{
    partial class Login
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
            this.tbLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.TbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.tbLayoutLogin.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutLogin
            // 
            this.tbLayoutLogin.BackColor = System.Drawing.Color.Transparent;
            this.tbLayoutLogin.ColumnCount = 1;
            this.tbLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tbLayoutLogin.Controls.Add(this.metroPanel1, 0, 0);
            this.tbLayoutLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutLogin.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutLogin.Name = "tbLayoutLogin";
            this.tbLayoutLogin.RowCount = 2;
            this.tbLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.21875F));
            this.tbLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tbLayoutLogin.Size = new System.Drawing.Size(811, 534);
            this.tbLayoutLogin.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.txtUserName);
            this.metroPanel1.Controls.Add(this.btnLogin);
            this.metroPanel1.Controls.Add(this.TbPassword);
            this.metroPanel1.Controls.Add(this.tbUserName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(223, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(364, 506);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(10, 237);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(63, 19);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(10, 208);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(71, 19);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "UserName";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(275, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(87, 233);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(263, 23);
            this.TbPassword.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(87, 204);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(263, 23);
            this.tbUserName.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLayoutLogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(811, 534);
            this.Load += new System.EventHandler(this.Login_Load);
            this.tbLayoutLogin.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayoutLogin;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox TbPassword;
        private MetroFramework.Controls.MetroTextBox tbUserName;
        private MetroFramework.Controls.MetroLabel txtPassword;
        private MetroFramework.Controls.MetroLabel txtUserName;
    }
}
