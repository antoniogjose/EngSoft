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
    public partial class EditRent : MetroFramework.Controls.MetroUserControl
    {
        private static EditRent _instance;

        public static EditRent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditRent();
                return _instance;
            }
        }
        public EditRent()
        {
            InitializeComponent();
        }
    }
}
