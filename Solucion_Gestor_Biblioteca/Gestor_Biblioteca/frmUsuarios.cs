using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Gestor_Biblioteca
{
    public partial class frmUsuarios : Form
    {
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        public frmUsuarios()
        {
            InitializeComponent();
            //CargarUsuariosDePrueba();
            CargarUsuarios();
        }

        private void CargarUsuariosDePrueba()
        {
            List<Usuario> usuarios = new List<Usuario>
                {
                    new Usuario { ID = 1, Nombre = "Juan", Apellido = "Pérez", DNI = "12345678", Telefono = "123456789", Email = "juan.perez@example.com", Imagen = "https://png.pngtree.com/thumb_back/fh260/background/20220209/pngtree-will-smith-imagecollect-fame-person-famous-photo-image_11807166.jpg", Suspendido = false },
                    new Usuario { ID = 2, Nombre = "María", Apellido = "Gómez", DNI = "87654321", Telefono = "987654321", Email = "maria.gomez@example.com", Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvC8zIOLOPLRfqButwbRHZZr-FufiIL6VVcvfD2EgJjjOZVZdyBpgww-NOa6F_SEwe5f4&usqp=CAU", Suspendido = false },
                    new Usuario { ID = 3, Nombre = "Carlos", Apellido = "López", DNI = "11223344", Telefono = "1122334455", Email = "carlos.lopez@example.com", Imagen = "https://cdn.businessinsider.es/sites/navi.axelspringer.es/public/media/image/2020/08/jennifer-lawrence-2026971.jpg?tf=3840x", Suspendido = true }
                };

            dgvUsuarios.DataSource = usuarios;

            //ocultar columna imagen
            dgvUsuarios.Columns["Imagen"].Visible = false;
        }

        private async void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
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

                    string imageUrl = selectedRow.Imagen;

                    try
                    {
                        // Si hay una URL válida, intentamos descargar la imagen
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                byte[] imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    pbFoto.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            // Si no hay URL, cargamos una imagen local
                            //pbFoto.Image = Properties.Resources.imagen_por_defecto_local; // Reemplaza con tu imagen local
                        }
                    }
                    catch
                    {
                        // Si ocurre algún error, cargamos una imagen local predeterminada
                        //pbFoto.Image = Properties.Resources.imagen_por_defecto_local;
                    }
                }
            }
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioNegocio.ObtenerUsuarios();

            dgvUsuarios.Columns["Imagen"].Visible = false;
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
    }
}
