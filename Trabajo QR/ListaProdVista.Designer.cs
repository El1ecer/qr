namespace Trabajo_QR
{
    partial class ListaProdVista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TablaProd = new DataGridView();
            cBoxTipoProd = new ComboBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaProd).BeginInit();
            SuspendLayout();
            // 
            // TablaProd
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveBorder;
            TablaProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TablaProd.BackgroundColor = SystemColors.ActiveBorder;
            TablaProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaProd.Location = new Point(10, 39);
            TablaProd.Name = "TablaProd";
            TablaProd.RowHeadersWidth = 51;
            TablaProd.Size = new Size(932, 292);
            TablaProd.TabIndex = 0;
            // 
            // cBoxTipoProd
            // 
            cBoxTipoProd.BackColor = SystemColors.ActiveBorder;
            cBoxTipoProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cBoxTipoProd.FormattingEnabled = true;
            cBoxTipoProd.Items.AddRange(new object[] { "Tableta", "Televisor", "Laptop", "Teclado", "Auriculares", "Camara de seguridad", "Tarjetas Graficas", "Aires acondicionados", "Telefono", "Monitor", "Mouse" });
            cBoxTipoProd.Location = new Point(14, 10);
            cBoxTipoProd.Name = "cBoxTipoProd";
            cBoxTipoProd.Size = new Size(197, 23);
            cBoxTipoProd.TabIndex = 28;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveBorder;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(706, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(787, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveBorder;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(867, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListaProdVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(953, 344);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(cBoxTipoProd);
            Controls.Add(TablaProd);
            Name = "ListaProdVista";
            Text = "ListaProdVista";
            Load += ListaProdVista_Load;
            ((System.ComponentModel.ISupportInitialize)TablaProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaProd;
        private ComboBox cBoxTipoProd;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}