using System;
using System.Windows.Forms;

namespace Gestor_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            frmUsuarios usuariosForm = new frmUsuarios();
            usuariosForm.Show();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para abrir el formulario de préstamos
        }
    }
}

