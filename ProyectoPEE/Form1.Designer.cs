namespace ProyectoPEE
{
    partial class Form1
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
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BTNSaludo = new System.Windows.Forms.Button();
            this.DgvCarrito = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fragilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDialogoProyecto = new System.Windows.Forms.Button();
            this.TxtFragilidad = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCalcularEnvio = new System.Windows.Forms.Button();
            this.BtnLlenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxSexo
            // 
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo",
            "No binario"});
            this.CbxSexo.Location = new System.Drawing.Point(36, 23);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(183, 24);
            this.CbxSexo.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(280, 23);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(183, 22);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.Text = "Escribe Tu Nombre";
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // BTNSaludo
            // 
            this.BTNSaludo.BackColor = System.Drawing.Color.RosyBrown;
            this.BTNSaludo.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSaludo.Location = new System.Drawing.Point(494, 12);
            this.BTNSaludo.Name = "BTNSaludo";
            this.BTNSaludo.Size = new System.Drawing.Size(183, 44);
            this.BTNSaludo.TabIndex = 5;
            this.BTNSaludo.Text = "Hola";
            this.BTNSaludo.UseVisualStyleBackColor = false;
            this.BTNSaludo.Click += new System.EventHandler(this.BTNSaludo_Click);
            // 
            // DgvCarrito
            // 
            this.DgvCarrito.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.DgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Producto,
            this.Cantidad,
            this.Peso,
            this.Fragilidad});
            this.DgvCarrito.Location = new System.Drawing.Point(36, 134);
            this.DgvCarrito.Name = "DgvCarrito";
            this.DgvCarrito.RowHeadersWidth = 51;
            this.DgvCarrito.RowTemplate.Height = 24;
            this.DgvCarrito.Size = new System.Drawing.Size(827, 233);
            this.DgvCarrito.TabIndex = 6;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            this.Peso.Width = 125;
            // 
            // Fragilidad
            // 
            this.Fragilidad.HeaderText = "Fragilidad";
            this.Fragilidad.MinimumWidth = 6;
            this.Fragilidad.Name = "Fragilidad";
            this.Fragilidad.Width = 125;
            // 
            // BtnDialogoProyecto
            // 
            this.BtnDialogoProyecto.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnDialogoProyecto.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDialogoProyecto.Location = new System.Drawing.Point(904, 59);
            this.BtnDialogoProyecto.Name = "BtnDialogoProyecto";
            this.BtnDialogoProyecto.Size = new System.Drawing.Size(183, 44);
            this.BtnDialogoProyecto.TabIndex = 15;
            this.BtnDialogoProyecto.Text = "Dialogo Proyecto";
            this.BtnDialogoProyecto.UseVisualStyleBackColor = false;
            this.BtnDialogoProyecto.Click += new System.EventHandler(this.BtnDialogoProyecto_Click);
            // 
            // TxtFragilidad
            // 
            this.TxtFragilidad.Location = new System.Drawing.Point(904, 345);
            this.TxtFragilidad.Name = "TxtFragilidad";
            this.TxtFragilidad.Size = new System.Drawing.Size(183, 22);
            this.TxtFragilidad.TabIndex = 14;
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(904, 318);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(183, 22);
            this.TxtPeso.TabIndex = 13;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevo.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(904, 134);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(183, 52);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCalcularEnvio
            // 
            this.BtnCalcularEnvio.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnCalcularEnvio.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularEnvio.Location = new System.Drawing.Point(904, 260);
            this.BtnCalcularEnvio.Name = "BtnCalcularEnvio";
            this.BtnCalcularEnvio.Size = new System.Drawing.Size(183, 52);
            this.BtnCalcularEnvio.TabIndex = 11;
            this.BtnCalcularEnvio.Text = "Calcular envio";
            this.BtnCalcularEnvio.UseVisualStyleBackColor = false;
            this.BtnCalcularEnvio.Click += new System.EventHandler(this.BtnCalcularEnvio_Click);
            // 
            // BtnLlenar
            // 
            this.BtnLlenar.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnLlenar.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLlenar.Location = new System.Drawing.Point(904, 192);
            this.BtnLlenar.Name = "BtnLlenar";
            this.BtnLlenar.Size = new System.Drawing.Size(183, 53);
            this.BtnLlenar.TabIndex = 10;
            this.BtnLlenar.Text = "Llenar datos";
            this.BtnLlenar.UseVisualStyleBackColor = false;
            this.BtnLlenar.Click += new System.EventHandler(this.BtnLlenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 581);
            this.Controls.Add(this.BtnDialogoProyecto);
            this.Controls.Add(this.TxtFragilidad);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCalcularEnvio);
            this.Controls.Add(this.BtnLlenar);
            this.Controls.Add(this.DgvCarrito);
            this.Controls.Add(this.BTNSaludo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CbxSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BTNSaludo;
        private System.Windows.Forms.DataGridView DgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fragilidad;
        private System.Windows.Forms.Button BtnDialogoProyecto;
        private System.Windows.Forms.TextBox TxtFragilidad;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCalcularEnvio;
        private System.Windows.Forms.Button BtnLlenar;
    }
}

