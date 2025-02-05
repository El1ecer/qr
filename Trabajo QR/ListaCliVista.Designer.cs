namespace Trabajo_QR
{
    partial class ListaCliVista
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
            btnLimpiar = new Button();
            btnBuscar = new Button();
            TablaCli = new DataGridView();
            txtBuscCed = new TextBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaCli).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(592, 6);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 34;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveBorder;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(481, 6);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TablaCli
            // 
            TablaCli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaCli.Location = new Point(10, 43);
            TablaCli.Margin = new Padding(3, 4, 3, 4);
            TablaCli.Name = "TablaCli";
            TablaCli.RowHeadersWidth = 51;
            TablaCli.Size = new Size(780, 389);
            TablaCli.TabIndex = 31;
            // 
            // txtBuscCed
            // 
            txtBuscCed.BackColor = SystemColors.ActiveBorder;
            txtBuscCed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtBuscCed.Location = new Point(11, 9);
            txtBuscCed.Margin = new Padding(3, 4, 3, 4);
            txtBuscCed.Name = "txtBuscCed";
            txtBuscCed.Size = new Size(234, 28);
            txtBuscCed.TabIndex = 35;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveBorder;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(705, 6);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListaCliVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(802, 444);
            Controls.Add(btnVolver);
            Controls.Add(txtBuscCed);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(TablaCli);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListaCliVista";
            Text = "ListaCli";
            Load += ListaCliVista_Load;
            ((System.ComponentModel.ISupportInitialize)TablaCli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnBuscar;
        private DataGridView TablaCli;
        private TextBox txtBuscCed;
        private Button btnVolver;
    }
}