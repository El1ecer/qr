namespace Trabajo_QR
{
    partial class VistaCliente
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
            lblCedula = new Label();
            txtCed = new TextBox();
            btnVolver = new Button();
            lblDirect = new Label();
            lblTelf = new Label();
            lblApe = new Label();
            lblNom = new Label();
            btnGenerar = new Button();
            txtDirectCli = new TextBox();
            txtTelfCli = new TextBox();
            txtApeCli = new TextBox();
            txtNomCli = new TextBox();
            btnLimpiar = new Button();
            QRCli = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            QRDescifrado = new PictureBox();
            txtClave = new TextBox();
            lblContra = new Label();
            ((System.ComponentModel.ISupportInitialize)QRCli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QRDescifrado).BeginInit();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.Transparent;
            lblCedula.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(157, 19);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(48, 15);
            lblCedula.TabIndex = 24;
            lblCedula.Text = "Cedula:";
            // 
            // txtCed
            // 
            txtCed.BackColor = SystemColors.InfoText;
            txtCed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCed.ForeColor = SystemColors.Window;
            txtCed.Location = new Point(214, 16);
            txtCed.Margin = new Padding(3, 2, 3, 2);
            txtCed.Name = "txtCed";
            txtCed.Size = new Size(223, 23);
            txtCed.TabIndex = 23;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.AliceBlue;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(285, 220);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDirect
            // 
            lblDirect.AutoSize = true;
            lblDirect.BackColor = Color.Transparent;
            lblDirect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDirect.Location = new Point(144, 118);
            lblDirect.Name = "lblDirect";
            lblDirect.Size = new Size(60, 15);
            lblDirect.TabIndex = 21;
            lblDirect.Text = "Direccion:";
            // 
            // lblTelf
            // 
            lblTelf.AutoSize = true;
            lblTelf.BackColor = Color.Transparent;
            lblTelf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelf.Location = new Point(150, 93);
            lblTelf.Name = "lblTelf";
            lblTelf.Size = new Size(57, 15);
            lblTelf.TabIndex = 20;
            lblTelf.Text = "Telefono:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.BackColor = Color.Transparent;
            lblApe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblApe.Location = new Point(150, 68);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(54, 15);
            lblApe.TabIndex = 19;
            lblApe.Text = "Apellido:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(150, 40);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(55, 15);
            lblNom.TabIndex = 18;
            lblNom.Text = "Nombre:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.AliceBlue;
            btnGenerar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(215, 173);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(97, 32);
            btnGenerar.TabIndex = 17;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtDirectCli
            // 
            txtDirectCli.BackColor = SystemColors.InfoText;
            txtDirectCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDirectCli.ForeColor = SystemColors.Window;
            txtDirectCli.Location = new Point(214, 115);
            txtDirectCli.Margin = new Padding(3, 2, 3, 2);
            txtDirectCli.Name = "txtDirectCli";
            txtDirectCli.Size = new Size(223, 24);
            txtDirectCli.TabIndex = 16;
            // 
            // txtTelfCli
            // 
            txtTelfCli.BackColor = SystemColors.InfoText;
            txtTelfCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTelfCli.ForeColor = SystemColors.Window;
            txtTelfCli.Location = new Point(214, 90);
            txtTelfCli.Margin = new Padding(3, 2, 3, 2);
            txtTelfCli.Name = "txtTelfCli";
            txtTelfCli.Size = new Size(223, 24);
            txtTelfCli.TabIndex = 15;
            // 
            // txtApeCli
            // 
            txtApeCli.BackColor = SystemColors.InactiveCaptionText;
            txtApeCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtApeCli.ForeColor = SystemColors.Window;
            txtApeCli.Location = new Point(214, 65);
            txtApeCli.Margin = new Padding(3, 2, 3, 2);
            txtApeCli.Name = "txtApeCli";
            txtApeCli.Size = new Size(223, 24);
            txtApeCli.TabIndex = 14;
            // 
            // txtNomCli
            // 
            txtNomCli.BackColor = SystemColors.InfoText;
            txtNomCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNomCli.ForeColor = SystemColors.Window;
            txtNomCli.Location = new Point(214, 40);
            txtNomCli.Margin = new Padding(3, 2, 3, 2);
            txtNomCli.Name = "txtNomCli";
            txtNomCli.Size = new Size(223, 24);
            txtNomCli.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.AliceBlue;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(340, 173);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 32);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // QRCli
            // 
            QRCli.BackColor = Color.Transparent;
            QRCli.BorderStyle = BorderStyle.FixedSingle;
            QRCli.Location = new Point(451, 16);
            QRCli.Name = "QRCli";
            QRCli.Size = new Size(222, 207);
            QRCli.SizeMode = PictureBoxSizeMode.Zoom;
            QRCli.TabIndex = 27;
            QRCli.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.clientes;
            pictureBox1.Location = new Point(3, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 27);
            label1.TabIndex = 29;
            label1.Text = "CLIENTES:";
            // 
            // QRDescifrado
            // 
            QRDescifrado.BackColor = Color.Transparent;
            QRDescifrado.BorderStyle = BorderStyle.FixedSingle;
            QRDescifrado.Location = new Point(695, 16);
            QRDescifrado.Name = "QRDescifrado";
            QRDescifrado.Size = new Size(222, 207);
            QRDescifrado.SizeMode = PictureBoxSizeMode.Zoom;
            QRDescifrado.TabIndex = 30;
            QRDescifrado.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.InactiveCaptionText;
            txtClave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtClave.ForeColor = SystemColors.MenuBar;
            txtClave.Location = new Point(214, 143);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(222, 24);
            txtClave.TabIndex = 99;
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.BackColor = Color.Transparent;
            lblContra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContra.Location = new Point(168, 147);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(40, 15);
            lblContra.TabIndex = 98;
            lblContra.Text = "Clave:";
            // 
            // VistaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 254);
            Controls.Add(txtClave);
            Controls.Add(lblContra);
            Controls.Add(QRDescifrado);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(QRCli);
            Controls.Add(btnLimpiar);
            Controls.Add(lblCedula);
            Controls.Add(txtCed);
            Controls.Add(btnVolver);
            Controls.Add(lblDirect);
            Controls.Add(lblTelf);
            Controls.Add(lblApe);
            Controls.Add(lblNom);
            Controls.Add(btnGenerar);
            Controls.Add(txtDirectCli);
            Controls.Add(txtTelfCli);
            Controls.Add(txtApeCli);
            Controls.Add(txtNomCli);
            Name = "VistaCliente";
            Text = "VistaCliente";
            Load += VistaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)QRCli).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QRDescifrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCedula;
        private TextBox txtCed;
        private Button btnVolver;
        private Label lblDirect;
        private Label lblTelf;
        private Label lblApe;
        private Label lblNom;
        private Button btnGenerar;
        private TextBox txtDirectCli;
        private TextBox txtTelfCli;
        private TextBox txtApeCli;
        private TextBox txtNomCli;
        private Button btnLimpiar;
        private PictureBox QRCli;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox QRDescifrado;
        private TextBox txtClave;
        private Label lblContra;
    }
}