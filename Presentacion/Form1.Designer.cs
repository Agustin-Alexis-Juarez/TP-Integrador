namespace Presentacion
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.panelCategoria = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.panelMarca = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.panelCriterio = new System.Windows.Forms.Panel();
            this.panelCampo = new System.Windows.Forms.Panel();
            this.panelFiltroAvanzado = new System.Windows.Forms.Panel();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelCategoria.SuspendLayout();
            this.panelMarca.SuspendLayout();
            this.panelCriterio.SuspendLayout();
            this.panelCampo.SuspendLayout();
            this.panelFiltroAvanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 38);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 25;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(526, 436);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(94, 6);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 3;
            this.cboCampo.TextChanged += new System.EventHandler(this.cboCampo_TextChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.Enabled = false;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(94, 6);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 2;
            this.cboCriterio.TextChanged += new System.EventHandler(this.cboCriterio_TextChanged);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(3, 12);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // btnELiminar
            // 
            this.btnELiminar.Location = new System.Drawing.Point(454, 480);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(75, 23);
            this.btnELiminar.TabIndex = 7;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.UseVisualStyleBackColor = true;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(94, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 480);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(535, 38);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(251, 193);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 4;
            this.pbxImagen.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(175, 480);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 8;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(48, 9);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelBuscar);
            this.panelContenedor.Controls.Add(this.panelCategoria);
            this.panelContenedor.Controls.Add(this.panelMarca);
            this.panelContenedor.Controls.Add(this.panelCriterio);
            this.panelContenedor.Controls.Add(this.panelCampo);
            this.panelContenedor.Controls.Add(this.panelFiltroAvanzado);
            this.panelContenedor.Location = new System.Drawing.Point(538, 237);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(312, 238);
            this.panelContenedor.TabIndex = 9;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.txtFiltroAvanzado);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(0, 179);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(312, 39);
            this.panelBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(178, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(51, 10);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroAvanzado.TabIndex = 5;
            this.txtFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroAvanzado_KeyPress);
            // 
            // panelCategoria
            // 
            this.panelCategoria.Controls.Add(this.lblCategoria);
            this.panelCategoria.Controls.Add(this.cboCategoria);
            this.panelCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategoria.Location = new System.Drawing.Point(0, 140);
            this.panelCategoria.Name = "panelCategoria";
            this.panelCategoria.Size = new System.Drawing.Size(312, 39);
            this.panelCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(36, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Enabled = false;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(94, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 0;
            // 
            // panelMarca
            // 
            this.panelMarca.Controls.Add(this.lblMarca);
            this.panelMarca.Controls.Add(this.cboMarca);
            this.panelMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarca.Location = new System.Drawing.Point(0, 101);
            this.panelMarca.Name = "panelMarca";
            this.panelMarca.Size = new System.Drawing.Size(312, 39);
            this.panelMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(51, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Enabled = false;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(94, 6);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 10;
            // 
            // panelCriterio
            // 
            this.panelCriterio.Controls.Add(this.cboCriterio);
            this.panelCriterio.Controls.Add(this.label2);
            this.panelCriterio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCriterio.Location = new System.Drawing.Point(0, 62);
            this.panelCriterio.Name = "panelCriterio";
            this.panelCriterio.Size = new System.Drawing.Size(312, 39);
            this.panelCriterio.TabIndex = 2;
            // 
            // panelCampo
            // 
            this.panelCampo.Controls.Add(this.lblCampo);
            this.panelCampo.Controls.Add(this.cboCampo);
            this.panelCampo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampo.Location = new System.Drawing.Point(0, 23);
            this.panelCampo.Name = "panelCampo";
            this.panelCampo.Size = new System.Drawing.Size(312, 39);
            this.panelCampo.TabIndex = 1;
            // 
            // panelFiltroAvanzado
            // 
            this.panelFiltroAvanzado.Controls.Add(this.lblFiltroAvanzado);
            this.panelFiltroAvanzado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltroAvanzado.Location = new System.Drawing.Point(0, 0);
            this.panelFiltroAvanzado.Name = "panelFiltroAvanzado";
            this.panelFiltroAvanzado.Size = new System.Drawing.Size(312, 23);
            this.panelFiltroAvanzado.TabIndex = 0;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(0, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(77, 13);
            this.lblFiltroAvanzado.TabIndex = 0;
            this.lblFiltroAvanzado.Text = "FiltroAvanzado";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 558);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnELiminar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelCategoria.ResumeLayout(false);
            this.panelCategoria.PerformLayout();
            this.panelMarca.ResumeLayout(false);
            this.panelMarca.PerformLayout();
            this.panelCriterio.ResumeLayout(false);
            this.panelCriterio.PerformLayout();
            this.panelCampo.ResumeLayout(false);
            this.panelCampo.PerformLayout();
            this.panelFiltroAvanzado.ResumeLayout(false);
            this.panelFiltroAvanzado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelCampo;
        private System.Windows.Forms.Panel panelFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Panel panelCriterio;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Panel panelCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Panel panelMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
    }
}

