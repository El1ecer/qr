namespace Trabajo_QR
{
    partial class ProductosVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosVista));
            btnVolver = new Button();
            btnLimpiar = new Button();
            lblCondificacion = new Label();
            txtCodificacion = new TextBox();
            lblCantidad = new Label();
            lblPrecioProd = new Label();
            lblGarantia = new Label();
            lblNom = new Label();
            lblUbiProd = new Label();
            lblMarca = new Label();
            lblTipoProd = new Label();
            txtCantProd = new TextBox();
            txtMarcaProd = new TextBox();
            cBoxTipoProd = new ComboBox();
            btnGenerar = new Button();
            QR = new PictureBox();
            txtPrecioProd = new TextBox();
            txtGarantiaProd = new TextBox();
            txtNomProd = new TextBox();
            txtUbiProd = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            QRDescifrado = new PictureBox();
            txtClave = new TextBox();
            lblContra = new Label();
            ((System.ComponentModel.ISupportInitialize)QR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QRDescifrado).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.AliceBlue;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(28, 228);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 41;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.AliceBlue;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(28, 188);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 40;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCondificacion
            // 
            lblCondificacion.AutoSize = true;
            lblCondificacion.BackColor = Color.Transparent;
            lblCondificacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCondificacion.Location = new Point(221, 86);
            lblCondificacion.Name = "lblCondificacion";
            lblCondificacion.Size = new Size(76, 15);
            lblCondificacion.TabIndex = 38;
            lblCondificacion.Text = "Codificacion:";
            // 
            // txtCodificacion
            // 
            txtCodificacion.BackColor = SystemColors.InfoText;
            txtCodificacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCodificacion.ForeColor = SystemColors.Window;
            txtCodificacion.Location = new Point(326, 81);
            txtCodificacion.Name = "txtCodificacion";
            txtCodificacion.Size = new Size(100, 24);
            txtCodificacion.TabIndex = 37;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(262, 234);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(38, 15);
            lblCantidad.TabIndex = 36;
            lblCantidad.Text = "Stock:";
            // 
            // lblPrecioProd
            // 
            lblPrecioProd.AutoSize = true;
            lblPrecioProd.BackColor = Color.Transparent;
            lblPrecioProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecioProd.Location = new Point(183, 139);
            lblPrecioProd.Name = "lblPrecioProd";
            lblPrecioProd.Size = new Size(114, 15);
            lblPrecioProd.TabIndex = 35;
            lblPrecioProd.Text = "Precio del producto:";
            // 
            // lblGarantia
            // 
            lblGarantia.AutoSize = true;
            lblGarantia.BackColor = Color.Transparent;
            lblGarantia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGarantia.Location = new Point(199, 113);
            lblGarantia.Name = "lblGarantia";
            lblGarantia.Size = new Size(103, 15);
            lblGarantia.TabIndex = 34;
            lblGarantia.Text = "Años de garantia:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(246, 208);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(55, 15);
            lblNom.TabIndex = 33;
            lblNom.Text = "Nombre:";
            // 
            // lblUbiProd
            // 
            lblUbiProd.AutoSize = true;
            lblUbiProd.BackColor = Color.Transparent;
            lblUbiProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUbiProd.Location = new Point(236, 175);
            lblUbiProd.Name = "lblUbiProd";
            lblUbiProd.Size = new Size(62, 15);
            lblUbiProd.TabIndex = 32;
            lblUbiProd.Text = "Ubicacion:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(184, 51);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(115, 15);
            lblMarca.TabIndex = 31;
            lblMarca.Text = "Marca del Producto:";
            // 
            // lblTipoProd
            // 
            lblTipoProd.AutoSize = true;
            lblTipoProd.BackColor = Color.Transparent;
            lblTipoProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTipoProd.Location = new Point(183, 18);
            lblTipoProd.Name = "lblTipoProd";
            lblTipoProd.Size = new Size(102, 15);
            lblTipoProd.TabIndex = 30;
            lblTipoProd.Text = "Tipo de Producto:";
            // 
            // txtCantProd
            // 
            txtCantProd.BackColor = SystemColors.InactiveCaptionText;
            txtCantProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCantProd.ForeColor = SystemColors.Window;
            txtCantProd.Location = new Point(326, 229);
            txtCantProd.Name = "txtCantProd";
            txtCantProd.Size = new Size(100, 24);
            txtCantProd.TabIndex = 29;
            // 
            // txtMarcaProd
            // 
            txtMarcaProd.BackColor = SystemColors.InactiveCaptionText;
            txtMarcaProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMarcaProd.ForeColor = SystemColors.InactiveBorder;
            txtMarcaProd.Location = new Point(326, 46);
            txtMarcaProd.Name = "txtMarcaProd";
            txtMarcaProd.Size = new Size(100, 24);
            txtMarcaProd.TabIndex = 28;
            // 
            // cBoxTipoProd
            // 
            cBoxTipoProd.BackColor = SystemColors.InactiveCaptionText;
            cBoxTipoProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cBoxTipoProd.ForeColor = SystemColors.InactiveBorder;
            cBoxTipoProd.FormattingEnabled = true;
            cBoxTipoProd.Items.AddRange(new object[] { "Tableta", "Televisor", "Laptop", "Teclado", "Auriculares", "Camara de seguridad", "Tarjetas Graficas", "Aires acondicionados", "Telefono", "Monitor", "Mouse" });
            cBoxTipoProd.Location = new Point(305, 12);
            cBoxTipoProd.Name = "cBoxTipoProd";
            cBoxTipoProd.Size = new Size(121, 23);
            cBoxTipoProd.TabIndex = 27;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.AliceBlue;
            btnGenerar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = SystemColors.ControlText;
            btnGenerar.Location = new Point(28, 147);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 26;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // QR
            // 
            QR.BackColor = Color.Transparent;
            QR.BorderStyle = BorderStyle.FixedSingle;
            QR.Location = new Point(447, 12);
            QR.Name = "QR";
            QR.Size = new Size(261, 238);
            QR.SizeMode = PictureBoxSizeMode.Zoom;
            QR.TabIndex = 25;
            QR.TabStop = false;
            // 
            // txtPrecioProd
            // 
            txtPrecioProd.BackColor = SystemColors.InactiveCaptionText;
            txtPrecioProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrecioProd.ForeColor = SystemColors.Window;
            txtPrecioProd.Location = new Point(326, 134);
            txtPrecioProd.Name = "txtPrecioProd";
            txtPrecioProd.Size = new Size(100, 24);
            txtPrecioProd.TabIndex = 24;
            // 
            // txtGarantiaProd
            // 
            txtGarantiaProd.BackColor = SystemColors.InactiveCaptionText;
            txtGarantiaProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtGarantiaProd.ForeColor = SystemColors.InactiveBorder;
            txtGarantiaProd.Location = new Point(326, 108);
            txtGarantiaProd.Name = "txtGarantiaProd";
            txtGarantiaProd.Size = new Size(100, 24);
            txtGarantiaProd.TabIndex = 23;
            // 
            // txtNomProd
            // 
            txtNomProd.BackColor = SystemColors.InfoText;
            txtNomProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNomProd.ForeColor = SystemColors.InactiveBorder;
            txtNomProd.Location = new Point(326, 203);
            txtNomProd.Name = "txtNomProd";
            txtNomProd.Size = new Size(100, 24);
            txtNomProd.TabIndex = 22;
            // 
            // txtUbiProd
            // 
            txtUbiProd.BackColor = SystemColors.InactiveCaptionText;
            txtUbiProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUbiProd.ForeColor = SystemColors.Window;
            txtUbiProd.Location = new Point(326, 170);
            txtUbiProd.Name = "txtUbiProd";
            txtUbiProd.Size = new Size(100, 24);
            txtUbiProd.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 43;
            label1.Text = "PRODUCTOS:";
            // 
            // QRDescifrado
            // 
            QRDescifrado.BackColor = Color.Transparent;
            QRDescifrado.BorderStyle = BorderStyle.FixedSingle;
            QRDescifrado.Location = new Point(728, 10);
            QRDescifrado.Name = "QRDescifrado";
            QRDescifrado.Size = new Size(261, 238);
            QRDescifrado.SizeMode = PictureBoxSizeMode.Zoom;
            QRDescifrado.TabIndex = 44;
            QRDescifrado.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(131, 227);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 45;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.BackColor = Color.Transparent;
            lblContra.Location = new Point(131, 192);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(39, 15);
            lblContra.TabIndex = 46;
            lblContra.Text = "Clave:";
            // 
            // ProductosVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 268);
            Controls.Add(lblContra);
            Controls.Add(txtClave);
            Controls.Add(QRDescifrado);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(lblCondificacion);
            Controls.Add(txtCodificacion);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecioProd);
            Controls.Add(lblGarantia);
            Controls.Add(lblNom);
            Controls.Add(lblUbiProd);
            Controls.Add(lblMarca);
            Controls.Add(lblTipoProd);
            Controls.Add(txtCantProd);
            Controls.Add(txtMarcaProd);
            Controls.Add(cBoxTipoProd);
            Controls.Add(btnGenerar);
            Controls.Add(QR);
            Controls.Add(txtPrecioProd);
            Controls.Add(txtGarantiaProd);
            Controls.Add(txtNomProd);
            Controls.Add(txtUbiProd);
            Name = "ProductosVista";
            Text = "ProductosVista";
            Load += ProductosVista_Load;
            ((System.ComponentModel.ISupportInitialize)QR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QRDescifrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnLimpiar;
        private Label lblCondificacion;
        private TextBox txtCodificacion;
        private Label lblCantidad;
        private Label lblPrecioProd;
        private Label lblGarantia;
        private Label lblNom;
        private Label lblUbiProd;
        private Label lblMarca;
        private Label lblTipoProd;
        private TextBox txtCantProd;
        private TextBox txtMarcaProd;
        private ComboBox cBoxTipoProd;
        private Button btnGenerar;
        private PictureBox QR;
        private TextBox txtPrecioProd;
        private TextBox txtGarantiaProd;
        private TextBox txtNomProd;
        private TextBox txtUbiProd;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox QRDescifrado;
        private TextBox txtClave;
        private Label lblContra;
    }
}