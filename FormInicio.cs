using System;
using System.Windows.Forms;
using GestorJuegos.Modelos;


namespace GestorJuegos
{
    public partial class FormInicio : Form
    {
        // Creamos el gestor de usuarios
        private GestorUsuarios gestor = new GestorUsuarios();

        public FormInicio()
        {
            InitializeComponent();
        }

        // Botón Acceder
        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.Trim();
            string contraseña = textBoxContraseña.Text.Trim();

            if (gestor.ValidarUsuario(usuario, contraseña))
            {
                // Si el login es correcto, abrimos el FormGestor
                GestorJuegos formGestor = new GestorJuegos();
                formGestor.Show();

                // Ocultamos el login
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
        }
    }
}

