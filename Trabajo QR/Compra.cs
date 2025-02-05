using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Windows.Forms;
using Trabajo_QR.Entidades;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace Trabajo_QR
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
            this.Paint += Compras_Paint;

        }
        public Clientes? CliGlobal { get; set; }
        public Compra(ClaseProd data)
        {
            InitializeComponent();
            lblIdProd1.Text = data.IdProd.ToString();
            lblTProd.Text = data.TipoProd;
            lblMPro.Text = data.MarcaProd;
            lblUPro.Text = data.UbicacionProd;
            lblCodPro.Text = data.CodProd;
            lblNPro.Text = data.NomProd;
            lblGPro.Text = data.GarantiaProd.ToString();
            lblPPro.Text = data.PrecioProd.ToString();
            lblSPro.Text = data.CantProd.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscedcli = new Clientes();
            buscedcli.CedCli = txtCedulaCli.Text;
            var data1 = buscedcli.BuscarCli(buscedcli);
            TablaCliOb.DataSource = data1;
        }

        private void TablaCliOb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = TablaCliOb.CurrentRow.Index; //Atrapando el indice de la fila actual
            if (selected == -1)
            {
                MessageBox.Show("No se encuentra ninguna fila");
            }
            else
            {
                CliGlobal = new Clientes();
                CliGlobal.CedCli = TablaCliOb.Rows[selected].Cells[0].Value.ToString();
                CliGlobal.NomCli = TablaCliOb.Rows[selected].Cells[1].Value.ToString();
                CliGlobal.ApeCli = TablaCliOb.Rows[selected].Cells[2].Value.ToString();
                CliGlobal.TelfCli = TablaCliOb.Rows[selected].Cells[3].Value.ToString();
                CliGlobal.DirectCli = TablaCliOb.Rows[selected].Cells[4].Value.ToString();
            }
        }

        private void obtenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCedCli1.Text = CliGlobal.CedCli.ToString();
            lblNomCli1.Text = CliGlobal.NomCli.ToString();
            lblApeCli1.Text = CliGlobal.ApeCli.ToString();
            lblTelfCli1.Text = CliGlobal.TelfCli.ToString();
            lblDirectCli1.Text = CliGlobal.DirectCli.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string datos = ObtenerDatos();

            string claveCifrado = "ClaveSecreta123";
            string claveingresada = txtClave.Text;
            try
            {
                string datosCifrados = CifrarDatos(datos, claveCifrado);
                string datosDescifrados = DescifrarDatos(datosCifrados, claveingresada);
                Bitmap codigoQR = GenerarCodigoQR(datosCifrados);
                Bitmap DesQR = GenerarCodigoQR(datosDescifrados);

                // Mostrar el c�digo QR en un PictureBox o hacer lo que desees con �l
                QRVen.Image = codigoQR;
                nuevoparacifrado.Image = DesQR;
            }
            catch (CryptographicException)
            {
                // La excepción indica que la clave es incorrecta
                MessageBox.Show("Clave incorrecta. Por favor, inténtelo de nuevo.", "Error de Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Mostrar el c�digo QR en un PictureBox o hacer lo que desees con �l
            


            var Prod = new ClaseProd();
            Prod.IdProd = Convert.ToInt32(lblIdProd1.Text);
            Prod.CodProd = lblCodPro.Text;
            Prod.TipoProd = lblTProd.Text;
            Prod.MarcaProd = lblMPro.Text;
            Prod.UbicacionProd = lblUPro.Text;
            Prod.NomProd = lblNPro.Text;
            Prod.GarantiaProd = Convert.ToInt32(lblGPro.Text);
            Prod.PrecioProd = Convert.ToDouble(lblPPro.Text);
            Prod.CantProd = Convert.ToInt32(lblSPro.Text) - Convert.ToInt32(txtCantVen.Text);

            //string sql = $"update productos set CantProd = {Sto} Where IdProd = {Id};";
            //var mysqlconection = new ConexionMySQL();
            Prod.Actualizar(Prod);

            var Venta = new ClaseVentas();
            Venta.IdPro = Convert.ToInt32(lblIdProd1.Text);
            Venta.EstadoVen = "Comprado";
            Venta.IdCli = lblCedCli1.Text;
            Venta.CantVen = Convert.ToInt32(txtCantVen.Text);
            Venta.ValorTotalVen = Math.Round(Convert.ToDouble(lblPPro.Text) * Convert.ToDouble(txtCantVen.Text), 2);

            Venta.CrearVenta(Venta);

            lblPTotal1.Text = Venta.ValorTotalVen.ToString();
        }
        private string ObtenerDatos()
        {
            // Aqu� obtienes los datos de tus controles
            string datos = $"{lblIdProd1.Text}, {lblCedCli1.Text}, {txtCantVen.Text}";
            return datos;
        }
        private string CifrarDatos(string datos, string clave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Utilizar PBKDF2 para generar una clave v�lida de 256 bits
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(clave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aesAlg.Key = keyDerivation.GetBytes(32); // 256 bits
                aesAlg.IV = new byte[16]; // IV (Vector de Inicializaci�n) debe ser �nico y aleatorio

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(datos);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        private string DescifrarDatos(string datosCifrados, string clave)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Utilizar PBKDF2 para generar una clave v�lida de 256 bits
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(clave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aesAlg.Key = keyDerivation.GetBytes(32); // 256 bits
                aesAlg.IV = new byte[16]; // IV (Vector de Inicializaci�n) debe ser �nico y aleatorio

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(datosCifrados)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
        private Bitmap GenerarCodigoQR(string datos)
        {
            // Configurar opciones del c�digo QR
            EncodingOptions opciones = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 300,
                Margin = 0 // Margen del c�digo QR
            };

            // Configurar el escritor de c�digos QR
            BarcodeWriterPixelData barcodeWriter = new BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = opciones
            };

            // Obtener p�xeles del c�digo QR
            PixelData pixelData = barcodeWriter.Write(datos);

            // Crear un bitmap a partir de los p�xeles
            Bitmap codigoQR = new Bitmap(pixelData.Width, pixelData.Height);

            for (int y = 0; y < pixelData.Height; y++)
            {
                for (int x = 0; x < pixelData.Width; x++)
                {
                    int index = (y * pixelData.Width + x) * 4; // 4 bytes por p�xel (RGBA)
                    int valor = pixelData.Pixels[index]; // Aqu� puedes acceder al valor del p�xel, o tambi�n R, G, B, A
                    codigoQR.SetPixel(x, y, valor == 0 ? Color.Black : Color.White);
                }
            }

            return codigoQR;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new ProdVentas();
            volver.Show();
            this.Hide();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            var data = clientes.ListaClientes();
            TablaCliOb.DataSource = data;
            gifcompra.Image = Properties.Resources.gifcompra;

        }
        private void Compras_Paint(object sender, PaintEventArgs e)
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

            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }

        private void QRVen_Click(object sender, EventArgs e)
        {

        }

        private void gifcompra_Click(object sender, EventArgs e)
        {

        }
    }
}
