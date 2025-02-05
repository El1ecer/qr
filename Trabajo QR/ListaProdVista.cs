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
    public partial class ListaProdVista : Form
    {
        public ListaProdVista()
        {
            InitializeComponent();
        }

        private void ListaProdVista_Load(object sender, EventArgs e)
        {
            var productos = new ClaseProd();
            var data = productos.ListaProductos();
            TablaProd.DataSource = data;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var prodtipo = new ClaseProd();
            prodtipo.TipoProd = cBoxTipoProd.Text;
            var data1 = prodtipo.BuscarEstu(prodtipo);
            TablaProd.DataSource = data1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var productos = new ClaseProd();
            var data = productos.ListaProductos();
            TablaProd.DataSource = data;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new Form1();
            volver.Show();
            this.Hide();
        }
    }
}
