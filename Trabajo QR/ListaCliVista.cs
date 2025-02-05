using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_QR.Entidades;

namespace Trabajo_QR
{
    public partial class ListaCliVista : Form
    {
        public ListaCliVista()
        {
            InitializeComponent();
        }
        private void ListaCliVista_Load(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            var data = clientes.ListaClientes();
            TablaCli.DataSource = data;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cedcli = new Clientes();
            cedcli.CedCli = txtBuscCed.Text;
            var data1 = cedcli.BuscarCli(cedcli);
            TablaCli.DataSource = data1;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            var data = clientes.ListaClientes();
            TablaCli.DataSource = data;
            txtBuscCed.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new Form1();
            volver.Show();
            this.Hide();
        }

    }
}
