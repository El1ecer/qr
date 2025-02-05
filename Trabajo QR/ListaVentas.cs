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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Trabajo_QR
{
    public partial class ListaVentas : Form
    {
        public ListaVentas()
        {
            InitializeComponent();
        }

        public ClaseVentas VentaGlobal { get; set; }
        private void ListaVentas_Load(object sender, EventArgs e)
        {
            var ventas = new ClaseVentas();
            var data = ventas.ListaVentas();
            TablaVentas.DataSource = data;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new Form1();
            volver.Show();
            this.Hide();
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
                VentaGlobal = new ClaseVentas();
                VentaGlobal.IdVenta = Convert.ToInt32(TablaVentas.Rows[selected].Cells[0].Value);
                VentaGlobal.EstadoVen = TablaVentas.Rows[selected].Cells[1].Value.ToString();
                VentaGlobal.IdPro = Convert.ToInt32(TablaVentas.Rows[selected].Cells[2].Value.ToString());
                VentaGlobal.IdCli = TablaVentas.Rows[selected].Cells[3].Value.ToString();
                VentaGlobal.CantVen = Convert.ToInt32(TablaVentas.Rows[selected].Cells[4].Value);
                VentaGlobal.ValorTotalVen = Convert.ToDouble(TablaVentas.Rows[selected].Cells[5].Value.ToString());

            }
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VentaG = new ClaseVentas();
            VentaG.IdVenta = VentaGlobal.IdVenta;
            VentaG.EstadoVen = "Devuelto";
            VentaG.IdPro = VentaGlobal.IdPro;
            VentaG.IdCli = VentaGlobal.IdCli;
            VentaG.CantVen = VentaGlobal.CantVen;
            VentaG.ValorTotalVen = VentaGlobal.ValorTotalVen;
            VentaG.ActualizarVen(VentaG);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var ventas = new ClaseVentas();
            var data = ventas.ListaVentas();
            TablaVentas.DataSource = data;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var venest = new ClaseVentas();
            venest.EstadoVen = comboBoxBuscar.Text;
            var data1 = venest.BuscarVen(venest);
            TablaVentas.DataSource = data1;
        }
    }
}
