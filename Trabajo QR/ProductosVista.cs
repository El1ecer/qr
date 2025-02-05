using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using Trabajo_QR.Entidades;
using System.Drawing.Drawing2D;

namespace Trabajo_QR
{
    public partial class ProductosVista : Form
    {
        public ProductosVista()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var volver = new Form1();
            volver.Show();
            this.Hide();
        }
        private string ObtenerDosPrimerasLetras(string texto)
        {
            if (texto.Length >= 2)
                return texto.Substring(0, 2);
            else
                return texto;
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nombre = ObtenerDosPrimerasLetras(txtNomProd.Text);
            string ubicacion = ObtenerDosPrimerasLetras(txtUbiProd.Text);
            string modelo = ObtenerDosPrimerasLetras(txtMarcaProd.Text);

            // Mostrar las dos primeras letras concatenadas en el TextBox txtResultado
            txtCodificacion.Text = nombre + ubicacion + modelo;
            // Obtener datos de TextBox y ComboBox
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
                QR.Image = codigoQR;
                QRDescifrado.Image = DesQR;
            }
            catch (CryptographicException)
            {
                // La excepción indica que la clave es incorrecta
                MessageBox.Show("Clave incorrecta. Por favor, inténtelo de nuevo.", "Error de Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Generar c�digo QR con datos cifrados
            

            // Mostrar el c�digo QR en un PictureBox o hacer lo que desees con �l            

            var Producto = new ClaseProd();
            Producto.TipoProd = cBoxTipoProd.Text;
            Producto.MarcaProd = txtMarcaProd.Text;
            Producto.UbicacionProd = txtUbiProd.Text;
            Producto.CodProd = txtCodificacion.Text;
            Producto.NomProd = txtNomProd.Text;
            Producto.GarantiaProd = Convert.ToInt32(txtGarantiaProd.Text);
            Producto.PrecioProd = Convert.ToDouble(txtPrecioProd.Text);
            Producto.CantProd = Convert.ToInt32(txtCantProd.Text);

            Producto.CrearProducto(Producto);

        }
        private string ObtenerDatos()
        {
            // Aqu� obtienes los datos de tus controles
            string datos = $"{cBoxTipoProd.Text}, {txtMarcaProd.Text}, {txtUbiProd.Text}, {txtCodificacion.Text}, {txtNomProd.Text}, {txtGarantiaProd.Text}, {txtPrecioProd.Text}, {txtCantProd.Text}";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantProd.Clear();
            txtCodificacion.Clear();
            txtGarantiaProd.Clear();
            txtMarcaProd.Clear();
            txtNomProd.Clear();
            txtPrecioProd.Clear();
            txtUbiProd.Clear();
        }

        private void ProductosVista_Load(object sender, EventArgs e)
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
