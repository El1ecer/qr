using System.Drawing.Drawing2D;

namespace Trabajo_QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Paint += Form1_Paint;

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            var prod = new ProductosVista();
            prod.Show();
            this.Hide();
        }

        private void btnVerProd_Click(object sender, EventArgs e)
        {
            var verprod = new ListaProdVista();
            verprod.Show();
            this.Hide();
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            var vistacli = new VistaCliente();
            vistacli.Show();
            this.Hide();
        }

        private void btnVerCli_Click(object sender, EventArgs e)
        {
            var vercli = new ListaCliVista();
            vercli.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var ventas = new ProdVentas();
            ventas.Show();
            this.Hide();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            var verventas = new ListaVentas();
            verventas.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.waste;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Establecer los colores para el degradado
            Color colorInicio = Color.Beige;
            Color colorFin = Color.Gray;

            // Crear el pincel lineal para el degradado
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                colorInicio,
                colorFin,
                LinearGradientMode.Vertical); // Puedes cambiar a Horizontal si lo deseas

            // Dibujar el degradado en el fondo del formulario
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
    }
}
