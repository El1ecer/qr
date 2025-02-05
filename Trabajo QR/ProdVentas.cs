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
    public partial class ProdVentas : Form
    {
        public ClaseProd ProdGlobal { get; set; }
        public ProdVentas()
        {
            InitializeComponent();
            Configurar();

        }

        private void ProdVentas_Load(object sender, EventArgs e)
        {
            var productos = new ClaseProd();
            var data = productos.ListaProductos();
            TablaVentas.DataSource = data;
        }

        private void TablaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = TablaVentas.CurrentRow.Index; //Atrapando el indice de la fila actual
            if (selected == -1)
            {
                MessageBox.Show("No se encuentra ninguna fila");
            }
            else
            {
                ProdGlobal = new ClaseProd();
                ProdGlobal.IdProd = Convert.ToInt32(TablaVentas.Rows[selected].Cells[0].Value); ;
                ProdGlobal.CodProd = TablaVentas.Rows[selected].Cells[1].Value.ToString();
                ProdGlobal.TipoProd = TablaVentas.Rows[selected].Cells[2].Value.ToString();
                ProdGlobal.MarcaProd = TablaVentas.Rows[selected].Cells[3].Value.ToString();
                ProdGlobal.UbicacionProd = TablaVentas.Rows[selected].Cells[4].Value.ToString();
                ProdGlobal.NomProd = TablaVentas.Rows[selected].Cells[5].Value.ToString();
                ProdGlobal.GarantiaProd = Convert.ToInt32(TablaVentas.Rows[selected].Cells[6].Value);
                ProdGlobal.PrecioProd = Convert.ToDouble(TablaVentas.Rows[selected].Cells[7].Value);
                ProdGlobal.CantProd = Convert.ToInt32(TablaVentas.Rows[selected].Cells[8].Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var prodtipo = new ClaseProd();
            prodtipo.TipoProd = cBoxTipoProd.Text;
            var data1 = prodtipo.BuscarEstu(prodtipo);
            TablaVentas.DataSource = data1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var productos = new ClaseProd();
            var data = productos.ListaProductos();
            TablaVentas.DataSource = data;
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formeditar = new Compra(ProdGlobal);
            formeditar.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new Form1();
            volver.Show();
            this.Hide();
        }

        private void Configurar()
        {
            TablaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            TablaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

    }
}
