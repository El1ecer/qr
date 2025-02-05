namespace Trabajo_QR
{
    partial class ListaVentas
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
            devolucionToolStripMenuItem = new ToolStripMenuItem();
            btnVolver = new Button();
            btnActualizar = new Button();
            btnBuscar = new Button();
            comboBoxBuscar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TablaVentas).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TablaVentas
            // 
            TablaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaVentas.ContextMenuStrip = contextMenuStrip1;
            TablaVentas.Location = new Point(14, 52);
            TablaVentas.Margin = new Padding(3, 4, 3, 4);
            TablaVentas.Name = "TablaVentas";
            TablaVentas.RowHeadersWidth = 51;
            TablaVentas.Size = new Size(887, 276);
            TablaVentas.TabIndex = 0;
            TablaVentas.CellClick += TablaVentas_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { devolucionToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(154, 28);
            // 
            // devolucionToolStripMenuItem
            // 
            devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            devolucionToolStripMenuItem.Size = new Size(153, 24);
            devolucionToolStripMenuItem.Text = "Devolucion";
            devolucionToolStripMenuItem.Click += devolucionToolStripMenuItem_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveBorder;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(815, 13);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveBorder;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(703, 13);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveBorder;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(588, 13);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // comboBoxBuscar
            // 
            comboBoxBuscar.BackColor = SystemColors.ActiveBorder;
            comboBoxBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxBuscar.FormattingEnabled = true;
            comboBoxBuscar.Items.AddRange(new object[] { "Comprado", "Devuelto" });
            comboBoxBuscar.Location = new Point(14, 13);
            comboBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            comboBoxBuscar.Name = "comboBoxBuscar";
            comboBoxBuscar.Size = new Size(225, 28);
            comboBoxBuscar.TabIndex = 4;
            // 
            // ListaVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(914, 355);
            Controls.Add(comboBoxBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(TablaVentas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListaVentas";
            Text = "ListaVentas";
            Load += ListaVentas_Load;
            ((System.ComponentModel.ISupportInitialize)TablaVentas).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaVentas;
        private Button btnVolver;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem devolucionToolStripMenuItem;
        private Button btnActualizar;
        private Button btnBuscar;
        private ComboBox comboBoxBuscar;
    }
}