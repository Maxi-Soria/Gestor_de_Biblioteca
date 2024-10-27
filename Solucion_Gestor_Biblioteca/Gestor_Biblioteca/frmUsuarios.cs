using Modelo;
using Negocio;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gestor_Biblioteca
{
    public partial class frmUsuarios : Form
    {
        bool modificar = false;
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private Usuario usuarioSeleccionado;


        public frmUsuarios()
        {
            InitializeComponent();


            CargarUsuarios();
        }


        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                usuarioSeleccionado = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                if (usuarioSeleccionado != null)
                {
                    txtNombre.Text = usuarioSeleccionado.Nombre;
                    txtApellido.Text = usuarioSeleccionado.Apellido;
                    txtEmail.Text = usuarioSeleccionado.Email;
                    txtTelefono.Text = usuarioSeleccionado.Telefono;
                    txtDNI.Text = usuarioSeleccionado.DNI;
                    chkSuspendido.Checked = usuarioSeleccionado.Suspendido;

                    pbFoto.Image = null; // Limpiar imagen antes de cargar una nueva

                    string imagePath = Path.Combine(Application.StartupPath, usuarioSeleccionado.Imagen);

                    try
                    {
                        // Si hay una ruta válida, intentamos cargar la imagen local
                        if (File.Exists(imagePath))
                        {
                            pbFoto.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            // Si no hay ruta, cargamos una imagen local predeterminada
                            pbFoto.Image = Properties.Resources.defaultimagenes; // Reemplaza con tu imagen local en recursos
                        }
                    }
                    catch
                    {
                        // Si ocurre algún error, cargamos una imagen local predeterminada
                        pbFoto.Image = Properties.Resources.defaultimagenes; // Reemplaza con tu imagen local en recursos
                    }
                }
            }
        }


        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioNegocio.ObtenerUsuarios();

            dgvUsuarios.Columns["Imagen"].Visible = false;
            dgvUsuarios.Columns["ID"].Visible = false;
            dgvUsuarios.Columns["Email"].Width = 200; // Ajusta este valor según sea necesario


            MostrarPaneles(false);
            bloquearCampos(false);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            bloquearCampos(true);
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                MostrarPaneles(true);
                dgvUsuarios.Enabled = false;
                modificar = true;
                txtDNI.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Usuario usuario = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                    usuarioNegocio.EliminarUsuario(usuario.ID);
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bloquearCampos(true);
            MostrarPaneles(true);
            dgvUsuarios.Enabled = false;
            dgvUsuarios.ClearSelection();
            pbFoto.Image = Properties.Resources.defaultimagenes;

            //Vaciar Campos
            LimpiarCampos();

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    String rutaImagenSeleccionada = openFileDialog.FileName;

                    // Cargar la imagen en el PictureBox
                    pbFoto.Image = Image.FromFile(rutaImagenSeleccionada);
                }
            }
        }

        private void btnSalir(object sender, EventArgs e)
        {
            MostrarPaneles(false);
            dgvUsuarios.Enabled = true;
            CargarUsuarios();
            dgvUsuarios.SelectedRows[0].Selected = true;


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            if (modificar && usuarioSeleccionado != null)
            {
                // Editar el usuario existente
                usuarioSeleccionado.Nombre = txtNombre.Text;
                usuarioSeleccionado.Apellido = txtApellido.Text;
                usuarioSeleccionado.Email = txtEmail.Text;
                usuarioSeleccionado.Telefono = txtTelefono.Text;
                usuarioSeleccionado.Suspendido = chkSuspendido.Checked;

                // Guardar la imagen en la carpeta de la aplicación
                string nombreImagen = $"{usuarioSeleccionado.Nombre}_{usuarioSeleccionado.Apellido}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
                string rutaImagen = Path.Combine(Application.StartupPath, nombreImagen);
                pbFoto.Image.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);
                usuarioSeleccionado.Imagen = nombreImagen;

                usuarioNegocio.ActualizarUsuario(usuarioSeleccionado);

                MessageBox.Show("Usuario actualizado con éxito.");
            }
            else
            {
                // Insertar un nuevo usuario
                if (usuarioNegocio.ExisteDNI(txtDNI.Text))
                {
                    MessageBox.Show("El DNI ya existe en la base de datos");
                    return;
                }

                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    DNI = txtDNI.Text,
                    Suspendido = chkSuspendido.Checked
                };

                // Guardar la imagen en la carpeta de la aplicación
                string nombreImagen = $"{nuevo.Nombre}_{nuevo.Apellido}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
                string rutaImagen = Path.Combine(Application.StartupPath, nombreImagen);
                pbFoto.Image.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);
                nuevo.Imagen = nombreImagen;

                usuarioNegocio.InsertarUsuario(nuevo);
                MessageBox.Show("Usuario insertado con éxito.");
            }

            LimpiarCampos();
            MostrarPaneles(false);
            CargarUsuarios();

            // Esperar a que el DataGridView se actualice y luego seleccionar la última fila
            int cantidad = dgvUsuarios.Rows.Count;
            if (cantidad > 0)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.Rows[cantidad - 1].Selected = true;
            }
            dgvUsuarios.Enabled = true;
            modificar = false;
            usuarioSeleccionado = null;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDNI.Text = "";
            chkSuspendido.Checked = false;
            //pbUsuarioNuevo.Image = Properties.Resources.defaultimagenes; // Reemplaza con tu imagen local en recursos;
        }

        private void MostrarPaneles(bool oculto)
        {
            pnlUsuarioNuevo.Visible = oculto;
            pnlGrabarNuevo.Visible = oculto;
        }

        private void bloquearCampos(bool bloqueo)
        {
            txtNombre.Enabled = bloqueo;
            txtApellido.Enabled = bloqueo;
            txtEmail.Enabled = bloqueo;
            txtTelefono.Enabled = bloqueo;
            txtDNI.Enabled = bloqueo;
            chkSuspendido.Enabled = bloqueo;
        }
    }
}

