namespace Trabajo_QR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnProd = new Button();
            btnVerProd = new Button();
            btnCli = new Button();
            btnVerCli = new Button();
            btnVentas = new Button();
            btnVerVentas = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProd
            // 
            btnProd.BackColor = SystemColors.ActiveCaptionText;
            btnProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProd.ForeColor = SystemColors.ButtonHighlight;
            btnProd.Image = (Image)resources.GetObject("btnProd.Image");
            btnProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnProd.Location = new Point(44, 113);
            btnProd.Margin = new Padding(3, 4, 3, 4);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(121, 44);
            btnProd.TabIndex = 0;
            btnProd.Text = "Productos";
            btnProd.TextAlign = ContentAlignment.MiddleRight;
            btnProd.UseVisualStyleBackColor = false;
            btnProd.Click += btnProd_Click;
            // 
            // btnVerProd
            // 
            btnVerProd.BackColor = SystemColors.WindowText;
            btnVerProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerProd.ForeColor = SystemColors.ButtonFace;
            btnVerProd.Image = Properties.Resources.visibilidad;
            btnVerProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerProd.Location = new Point(197, 113);
            btnVerProd.Margin = new Padding(3, 4, 3, 4);
            btnVerProd.Name = "btnVerProd";
            btnVerProd.Size = new Size(153, 44);
            btnVerProd.TabIndex = 1;
            btnVerProd.Text = "Ver productos";
            btnVerProd.TextAlign = ContentAlignment.MiddleRight;
            btnVerProd.UseVisualStyleBackColor = false;
            btnVerProd.Click += btnVerProd_Click;
            // 
            // btnCli
            // 
            btnCli.BackColor = SystemColors.ActiveCaptionText;
            btnCli.BackgroundImageLayout = ImageLayout.Stretch;
            btnCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCli.ForeColor = SystemColors.ButtonHighlight;
            btnCli.Image = (Image)resources.GetObject("btnCli.Image");
            btnCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnCli.Location = new Point(44, 175);
            btnCli.Margin = new Padding(3, 4, 3, 4);
            btnCli.Name = "btnCli";
            btnCli.Size = new Size(121, 44);
            btnCli.TabIndex = 2;
            btnCli.Text = "Clientes";
            btnCli.TextAlign = ContentAlignment.MiddleRight;
            btnCli.UseVisualStyleBackColor = false;
            btnCli.Click += btnCli_Click;
            // 
            // btnVerCli
            // 
            btnVerCli.BackColor = SystemColors.WindowText;
            btnVerCli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerCli.ForeColor = SystemColors.ButtonHighlight;
            btnVerCli.Image = Properties.Resources.visibilidad;
            btnVerCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCli.Location = new Point(197, 175);
            btnVerCli.Margin = new Padding(3, 4, 3, 4);
            btnVerCli.Name = "btnVerCli";
            btnVerCli.Size = new Size(153, 44);
            btnVerCli.TabIndex = 3;
            btnVerCli.Text = "Ver clientes";
            btnVerCli.TextAlign = ContentAlignment.MiddleRight;
            btnVerCli.UseVisualStyleBackColor = false;
            btnVerCli.Click += btnVerCli_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.ActiveCaptionText;
            btnVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(44, 236);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(121, 44);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnVerVentas
            // 
            btnVerVentas.BackColor = SystemColors.ActiveCaptionText;
            btnVerVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVerVentas.Image = Properties.Resources.visibilidad;
            btnVerVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerVentas.Location = new Point(197, 236);
            btnVerVentas.Margin = new Padding(3, 4, 3, 4);
            btnVerVentas.Name = "btnVerVentas";
            btnVerVentas.Size = new Size(153, 44);
            btnVerVentas.TabIndex = 5;
            btnVerVentas.Text = "Ver ventas";
            btnVerVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVerVentas.UseVisualStyleBackColor = false;
            btnVerVentas.Click += btnVerVentas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(357, 50);
            label1.TabIndex = 6;
            label1.Text = "BODEGAS PEPITO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.InitialImage = Properties.Resources.waste;
            pictureBox1.Location = new Point(391, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(703, 322);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnVerVentas);
            Controls.Add(btnVentas);
            Controls.Add(btnVerCli);
            Controls.Add(btnCli);
            Controls.Add(btnVerProd);
            Controls.Add(btnProd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProd;
        private Button btnVerProd;
        private Button btnCli;
        private Button btnVerCli;
        private Button btnVentas;
        private Button btnVerVentas;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
