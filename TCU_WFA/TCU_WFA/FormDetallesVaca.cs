﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Models;

namespace TCU_WFA
{
    public partial class FormDetallesVaca : DefaultForm
    {
        private VacaModel informacionVacaSelecionada;
        public FormDetallesVaca(DataGridViewRow informacionVacaSeleccionada = null)
        {
            InitializeComponent();
            if (informacionVacaSeleccionada != null)
            {
                //TODO: inicializar los campos correspondientes de la clase
            }
        }
    }
}