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
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public frmUsuarios()
        {
            InitializeComponent();


            CargarUsuarios();
        }


        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                if (selectedRow != null)
                {
                    txtNombre.Text = selectedRow.Nombre;
                    txtApellido.Text = selectedRow.Apellido;
                    txtEmail.Text = selectedRow.Email;
                    txtTelefono.Text = selectedRow.Telefono;
                    txtDNI.Text = selectedRow.DNI;
                    chkSuspendido.Checked = selectedRow.Suspendido;

                    pbFoto.Image = null; // Limpiar imagen antes de cargar una nueva

                    string imagePath = Path.Combine(Application.StartupPath, selectedRow.Imagen);

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
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para modificar el usuario seleccionado.
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para eliminar el usuario seleccionado.
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MostrarPaneles(true);
            dgvUsuarios.Enabled = false;
            dgvUsuarios.ClearSelection();
            pbUsuarioNuevo.Image = Properties.Resources.defaultimagenes;

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
                    pbUsuarioNuevo.Image = Image.FromFile(rutaImagenSeleccionada);
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
            Usuario nuevo = new Usuario();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Email = txtEmail.Text;
            nuevo.Telefono = txtTelefono.Text;
            nuevo.DNI = txtDNI.Text;
            nuevo.Suspendido = false;

            // Guardar la imagen en la carpeta de la aplicación
            string nombreImagen = $"{nuevo.Nombre}_{nuevo.Apellido}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
            string rutaImagen = Path.Combine(Application.StartupPath, nombreImagen);
            pbUsuarioNuevo.Image.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);
            nuevo.Imagen = nombreImagen;

            // Aquí puedes agregar la lógica para guardar el nuevo usuario.
            usuarioNegocio.InsertarUsuario(nuevo);
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
    }
}

