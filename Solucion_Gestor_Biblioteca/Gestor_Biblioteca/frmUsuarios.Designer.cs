namespace Gestor_Biblioteca
{
    partial class frmUsuarios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblSuspendido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.CheckBox chkSuspendido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblSuspendido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.chkSuspendido = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlUsuarioNuevo = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbUsuarioNuevo = new System.Windows.Forms.PictureBox();
            this.pnlGrabarNuevo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabarNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlUsuarioNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioNuevo)).BeginInit();
            this.pnlGrabarNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(21, 87);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(722, 501);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(849, 87);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(788, 260);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(788, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(788, 340);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(788, 380);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(788, 420);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "DNI:";
            // 
            // lblSuspendido
            // 
            this.lblSuspendido.AutoSize = true;
            this.lblSuspendido.Location = new System.Drawing.Point(788, 460);
            this.lblSuspendido.Name = "lblSuspendido";
            this.lblSuspendido.Size = new System.Drawing.Size(66, 13);
            this.lblSuspendido.TabIndex = 13;
            this.lblSuspendido.Text = "Suspendido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(858, 257);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(858, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(858, 337);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(858, 377);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(858, 417);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 20);
            this.txtDNI.TabIndex = 15;
            // 
            // chkSuspendido
            // 
            this.chkSuspendido.AutoSize = true;
            this.chkSuspendido.Location = new System.Drawing.Point(858, 459);
            this.chkSuspendido.Name = "chkSuspendido";
            this.chkSuspendido.Size = new System.Drawing.Size(15, 14);
            this.chkSuspendido.TabIndex = 16;
            this.chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(791, 495);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(888, 495);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(983, 495);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pnlUsuarioNuevo
            // 
            this.pnlUsuarioNuevo.Controls.Add(this.btnCargarImagen);
            this.pnlUsuarioNuevo.Controls.Add(this.pbUsuarioNuevo);
            this.pnlUsuarioNuevo.Location = new System.Drawing.Point(770, 87);
            this.pnlUsuarioNuevo.Name = "pnlUsuarioNuevo";
            this.pnlUsuarioNuevo.Size = new System.Drawing.Size(309, 164);
            this.pnlUsuarioNuevo.TabIndex = 17;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(244, 96);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(55, 56);
            this.btnCargarImagen.TabIndex = 27;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbUsuarioNuevo
            // 
            this.pbUsuarioNuevo.Location = new System.Drawing.Point(78, 3);
            this.pbUsuarioNuevo.Name = "pbUsuarioNuevo";
            this.pbUsuarioNuevo.Size = new System.Drawing.Size(150, 150);
            this.pbUsuarioNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarioNuevo.TabIndex = 16;
            this.pbUsuarioNuevo.TabStop = false;
            // 
            // pnlGrabarNuevo
            // 
            this.pnlGrabarNuevo.Controls.Add(this.btnCancelar);
            this.pnlGrabarNuevo.Controls.Add(this.btnGrabarNuevo);
            this.pnlGrabarNuevo.Location = new System.Drawing.Point(770, 459);
            this.pnlGrabarNuevo.Name = "pnlGrabarNuevo";
            this.pnlGrabarNuevo.Size = new System.Drawing.Size(309, 75);
            this.pnlGrabarNuevo.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 49);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir);
            // 
            // btnGrabarNuevo
            // 
            this.btnGrabarNuevo.Location = new System.Drawing.Point(21, 12);
            this.btnGrabarNuevo.Name = "btnGrabarNuevo";
            this.btnGrabarNuevo.Size = new System.Drawing.Size(120, 49);
            this.btnGrabarNuevo.TabIndex = 0;
            this.btnGrabarNuevo.Text = "Grabar";
            this.btnGrabarNuevo.UseVisualStyleBackColor = true;
            this.btnGrabarNuevo.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 682);
            this.Controls.Add(this.pnlGrabarNuevo);
            this.Controls.Add(this.pnlUsuarioNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.chkSuspendido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblSuspendido);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "frmUsuarios";
            this.Text = "Gestión de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlUsuarioNuevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioNuevo)).EndInit();
            this.pnlGrabarNuevo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlUsuarioNuevo;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbUsuarioNuevo;
        private System.Windows.Forms.Panel pnlGrabarNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabarNuevo;
    }
}