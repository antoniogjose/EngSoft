﻿namespace ImoEstudantePLMetroUi
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuImoEstudante = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuImoEstudante_Idiom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Idiom_PT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Idiom_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_Idiom_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImoEstudante_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRents_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRents_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRents_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitations_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitations_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitations_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImoEstudante,
            this.menuRents,
            this.menuHabitations,
            this.menuClients,
            this.menuHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuImoEstudante
            // 
            this.menuImoEstudante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImoEstudante_Data,
            this.menuImoEstudante_Add,
            this.menuImoEstudante_Search,
            this.toolStripSeparator2,
            this.menuImoEstudante_Idiom,
            this.toolStripSeparator1,
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.menuImoEstudante_LogOut});
            this.menuImoEstudante.Name = "menuImoEstudante";
            resources.ApplyResources(this.menuImoEstudante, "menuImoEstudante");
            // 
            // menuImoEstudante_Data
            // 
            this.menuImoEstudante_Data.Name = "menuImoEstudante_Data";
            resources.ApplyResources(this.menuImoEstudante_Data, "menuImoEstudante_Data");
            this.menuImoEstudante_Data.Click += new System.EventHandler(this.menuToolStripMenuItem2_Click);
            // 
            // menuImoEstudante_Add
            // 
            this.menuImoEstudante_Add.Name = "menuImoEstudante_Add";
            resources.ApplyResources(this.menuImoEstudante_Add, "menuImoEstudante_Add");
            this.menuImoEstudante_Add.Click += new System.EventHandler(this.adicionarUtilizadorToolStripMenuItem1_Click);
            // 
            // menuImoEstudante_Search
            // 
            this.menuImoEstudante_Search.Name = "menuImoEstudante_Search";
            resources.ApplyResources(this.menuImoEstudante_Search, "menuImoEstudante_Search");
            this.menuImoEstudante_Search.Click += new System.EventHandler(this.adicionarUtilizadorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuImoEstudante_Idiom
            // 
            this.menuImoEstudante_Idiom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImoEstudante_Idiom_PT,
            this.menuImoEstudante_Idiom_EN,
            this.menuImoEstudante_Idiom_SP});
            this.menuImoEstudante_Idiom.Name = "menuImoEstudante_Idiom";
            resources.ApplyResources(this.menuImoEstudante_Idiom, "menuImoEstudante_Idiom");
            // 
            // menuImoEstudante_Idiom_PT
            // 
            this.menuImoEstudante_Idiom_PT.Checked = true;
            this.menuImoEstudante_Idiom_PT.CheckOnClick = true;
            this.menuImoEstudante_Idiom_PT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuImoEstudante_Idiom_PT.Name = "menuImoEstudante_Idiom_PT";
            resources.ApplyResources(this.menuImoEstudante_Idiom_PT, "menuImoEstudante_Idiom_PT");
            this.menuImoEstudante_Idiom_PT.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click);
            // 
            // menuImoEstudante_Idiom_EN
            // 
            this.menuImoEstudante_Idiom_EN.CheckOnClick = true;
            this.menuImoEstudante_Idiom_EN.Name = "menuImoEstudante_Idiom_EN";
            resources.ApplyResources(this.menuImoEstudante_Idiom_EN, "menuImoEstudante_Idiom_EN");
            this.menuImoEstudante_Idiom_EN.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // menuImoEstudante_Idiom_SP
            // 
            this.menuImoEstudante_Idiom_SP.Name = "menuImoEstudante_Idiom_SP";
            resources.ApplyResources(this.menuImoEstudante_Idiom_SP, "menuImoEstudante_Idiom_SP");
            this.menuImoEstudante_Idiom_SP.Click += new System.EventHandler(this.menuImoEstudante_Idiom_SP_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            resources.ApplyResources(this.logInToolStripMenuItem, "logInToolStripMenuItem");
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            // 
            // menuImoEstudante_LogOut
            // 
            this.menuImoEstudante_LogOut.Name = "menuImoEstudante_LogOut";
            resources.ApplyResources(this.menuImoEstudante_LogOut, "menuImoEstudante_LogOut");
            // 
            // menuRents
            // 
            this.menuRents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRents_Search,
            this.menuRents_Add,
            this.menuRents_List});
            this.menuRents.Name = "menuRents";
            resources.ApplyResources(this.menuRents, "menuRents");
            // 
            // menuRents_Search
            // 
            this.menuRents_Search.Name = "menuRents_Search";
            resources.ApplyResources(this.menuRents_Search, "menuRents_Search");
            this.menuRents_Search.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // menuRents_Add
            // 
            this.menuRents_Add.Name = "menuRents_Add";
            resources.ApplyResources(this.menuRents_Add, "menuRents_Add");
            this.menuRents_Add.Click += new System.EventHandler(this.btAddRent_Click);
            // 
            // menuRents_List
            // 
            this.menuRents_List.Name = "menuRents_List";
            resources.ApplyResources(this.menuRents_List, "menuRents_List");
            this.menuRents_List.Click += new System.EventHandler(this.listarToolStripMenuItem4_Click);
            // 
            // menuHabitations
            // 
            this.menuHabitations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHabitations_Search,
            this.menuHabitations_Add,
            this.menuHabitations_List});
            this.menuHabitations.Name = "menuHabitations";
            resources.ApplyResources(this.menuHabitations, "menuHabitations");
            // 
            // menuHabitations_Search
            // 
            this.menuHabitations_Search.Name = "menuHabitations_Search";
            resources.ApplyResources(this.menuHabitations_Search, "menuHabitations_Search");
            this.menuHabitations_Search.Click += new System.EventHandler(this.btSearchHouse_Click);
            // 
            // menuHabitations_Add
            // 
            this.menuHabitations_Add.Name = "menuHabitations_Add";
            resources.ApplyResources(this.menuHabitations_Add, "menuHabitations_Add");
            this.menuHabitations_Add.Click += new System.EventHandler(this.btAddHouse_Click);
            // 
            // menuHabitations_List
            // 
            this.menuHabitations_List.Name = "menuHabitations_List";
            resources.ApplyResources(this.menuHabitations_List, "menuHabitations_List");
            this.menuHabitations_List.Click += new System.EventHandler(this.btListHouse_Click);
            // 
            // menuClients
            // 
            this.menuClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClients_Search,
            this.menuClients_Add,
            this.menuClients_List});
            this.menuClients.Name = "menuClients";
            resources.ApplyResources(this.menuClients, "menuClients");
            // 
            // menuClients_Search
            // 
            this.menuClients_Search.Name = "menuClients_Search";
            resources.ApplyResources(this.menuClients_Search, "menuClients_Search");
            this.menuClients_Search.Click += new System.EventHandler(this.btSearchClient_Click);
            // 
            // menuClients_Add
            // 
            this.menuClients_Add.Name = "menuClients_Add";
            resources.ApplyResources(this.menuClients_Add, "menuClients_Add");
            this.menuClients_Add.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // menuClients_List
            // 
            this.menuClients_List.Name = "menuClients_List";
            resources.ApplyResources(this.menuClients_List, "menuClients_List");
            this.menuClients_List.Click += new System.EventHandler(this.btListClient_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            resources.ApplyResources(this.menuHelp, "menuHelp");
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Name = "panel";
            this.panel.VerticalScrollbar = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = true;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Idiom;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Data;
        private System.Windows.Forms.ToolStripMenuItem menuRents;
        private System.Windows.Forms.ToolStripMenuItem menuHabitations;

        private System.Windows.Forms.ToolStripMenuItem menuClients;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Idiom_PT;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Idiom_EN;
        private System.Windows.Forms.ToolStripMenuItem menuRents_Add;
        private System.Windows.Forms.ToolStripMenuItem menuRents_List;
        private System.Windows.Forms.ToolStripMenuItem menuHabitations_Add;
        private System.Windows.Forms.ToolStripMenuItem menuHabitations_List;
        private System.Windows.Forms.ToolStripMenuItem menuClients_Add;
        private System.Windows.Forms.ToolStripMenuItem menuClients_List;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Search;
        private System.Windows.Forms.ToolStripMenuItem menuRents_Search;
        private System.Windows.Forms.ToolStripMenuItem menuHabitations_Search;
        private System.Windows.Forms.ToolStripMenuItem menuClients_Search;
        private MetroFramework.Controls.MetroPanel panel;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_LogOut;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Add;
        private System.Windows.Forms.ToolStripMenuItem menuImoEstudante_Idiom_SP;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

