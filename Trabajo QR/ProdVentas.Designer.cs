namespace Trabajo_QR
{
    partial class ProdVentas
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
            components = new System.ComponentModel.Container();
            TablaVentas = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            compraToolStripMenuItem = new ToolStripMenuItem();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            cBoxTipoProd = new ComboBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaVentas).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TablaVentas
            // 
            TablaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaVentas.ContextMenuStrip = contextMenuStrip1;
            TablaVentas.Location = new Point(12, 39);
            TablaVentas.Name = "TablaVentas";
            TablaVentas.RowHeadersWidth = 51;
            TablaVentas.Size = new Size(774, 218);
            TablaVentas.TabIndex = 1;
            TablaVentas.CellClick += TablaVentas_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { compraToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 26);
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(117, 22);
            compraToolStripMenuItem.Text = "Compra";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(610, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveBorder;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(508, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cBoxTipoProd
            // 
            cBoxTipoProd.BackColor = SystemColors.ActiveBorder;
            cBoxTipoProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cBoxTipoProd.FormattingEnabled = true;
            cBoxTipoProd.Items.AddRange(new object[] { "Tableta", "Televisor", "Laptop", "Teclado", "Auriculares", "Camara de seguridad", "Tarjetas Graficas", "Aires acondicionados", "Telefono", "Monitor", "Mouse" });
            cBoxTipoProd.Location = new Point(12, 10);
            cBoxTipoProd.Name = "cBoxTipoProd";
            cBoxTipoProd.Size = new Size(197, 23);
            cBoxTipoProd.TabIndex = 31;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveBorder;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(711, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ProdVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 268);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(cBoxTipoProd);
            Controls.Add(TablaVentas);
            Name = "ProdVentas";
            Text = "ProdVentas";
            Load += ProdVentas_Load;
            ((System.ComponentModel.ISupportInitialize)TablaVentas).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaVentas;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem compraToolStripMenuItem;
        private Button btnLimpiar;
        private Button btnBuscar;
        private ComboBox cBoxTipoProd;
        private Button btnVolver;
    }
}