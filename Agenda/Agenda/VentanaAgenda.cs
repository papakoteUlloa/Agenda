using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class VentanaAgenda : Form
    {
        public VentanaAgenda()
        {
            InitializeComponent();
        }

        private void VentanaAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet.contactos);

        }
    }
}
