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
    public partial class SearchRent : MetroFramework.Controls.MetroUserControl
    {
        private static SearchRent _instance;

        public static SearchRent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchRent();
                return _instance;
            }
        }
        public SearchRent()
        {
            InitializeComponent();
        }
    }
}
