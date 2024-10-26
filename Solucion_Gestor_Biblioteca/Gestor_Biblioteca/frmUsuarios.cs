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
            // Aquí puedes agregar la lógica para agregar un nuevo usuario.
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

