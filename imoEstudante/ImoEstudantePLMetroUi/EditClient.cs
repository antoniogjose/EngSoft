﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImoEstudantePLMetroUi
{
    public partial class EditClient : MetroFramework.Controls.MetroUserControl
    {
        private static EditClient _instance;

        public static EditClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditClient();
                return _instance;
            }
        }
        public EditClient()
        {
            InitializeComponent();
        }
    }
}
