﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormAgregarVaca : DefaultForm
    {

        public FormAgregarVaca()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            FormRegistroVacas form = (FormRegistroVacas)Tag;
            form.Show();
            Close();
        }

        private void FormAgregarVaca_Load(object sender, EventArgs e)
        {

        }
    }
}