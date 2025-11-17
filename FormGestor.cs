using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorJuegos.Clases;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;
namespace GestorJuegos
{
    public partial class GestorJuegos : Form

    {

        List<Juego> listaJuegos;


        public GestorJuegos()
        {
            InitializeComponent();

            // Color form principal
            this.BackColor = Color.FromArgb(37, 37, 38);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Color panel detalle
            panelDetalle.BackColor = Color.FromArgb(50, 50, 55);
            panelDetalle.BorderStyle = BorderStyle.FixedSingle;
            panelDetalle.Visible = false; // oculta el panel al iniciar el form

            // Labels del panel detalle
            labelNombre.ForeColor = Color.White;
            labelNombre.Font = new Font("Montserrat", 16, FontStyle.Bold);

            foreach (var lbl in new[] { labelPreguntas, labelPuntuacion, labelErrores, labelTiempo })
            {
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Montserrat", 14, FontStyle.Regular);
            }

            // DataGridView estilo
            dataGridViewJuegos.BackgroundColor = Color.FromArgb(30, 30, 35);
            dataGridViewJuegos.ForeColor = Color.Black;
            dataGridViewJuegos.GridColor = Color.FromArgb(60, 60, 65);
            dataGridViewJuegos.EnableHeadersVisualStyles = false;
            dataGridViewJuegos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewJuegos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewJuegos.RowHeadersVisible = false;
            dataGridViewJuegos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewJuegos.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewJuegos.Width = 838;
            dataGridViewJuegos.Height = 150;
            dataGridViewJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // columnas se ajustan al ancho
            dataGridViewJuegos.AllowUserToResizeColumns = false; // evita que el usuario cambie tamaño
            dataGridViewJuegos.AllowUserToResizeRows = false;


            dataGridViewJuegos.SelectionChanged += dataGridViewJuegos_SelectionChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Ficheros JSON(*.json)|*.json";

            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaArchivo.Text = openFile.FileName;

                JArray jarrayJuegos = JArray.Parse(File.ReadAllText(textBoxRutaArchivo.Text, Encoding.Default));
                listaJuegos = jarrayJuegos.ToObject<List<Juego>>();

                dataGridViewJuegos.DataSource = listaJuegos;
                dataGridViewJuegos.AutoResizeColumns();
            }
        }

        private void dataGridViewJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void dataGridViewJuegos_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewJuegos.CurrentRow == null)
                return;

            var juego = dataGridViewJuegos.CurrentRow.DataBoundItem as Juego;

            if (juego == null)
                return;

            panelDetalle.Visible = true;

            labelNombre.Text = $"Jugador: {juego.nombreJugador}";
            labelPreguntas.Text = $"Preguntas: {juego.numPreguntas}";
            labelPuntuacion.Text = $"Puntuación: {juego.puntuacion}";
            labelErrores.Text = $"Errores: {juego.errores}";
            labelTiempo.Text = $"Tiempo: {juego.tiempoPartida}";
        }

        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Ficheros JSON(*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = openFile.FileName;

                DialogResult result = MessageBox.Show(
                $"¿Estás seguro que quieres borrar el archivo?\n{archivoSeleccionado}",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(archivoSeleccionado);
                        MessageBox.Show("Archivo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Ficheros JSON(*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string archivoActual = openFile.FileName;
                string carpeta = Path.GetDirectoryName(archivoActual);

                // Solicitar nuevo nombre al usuario en un formulario del microsoft visual basic
                string nuevoNombre = Interaction.InputBox(
                    "Introduce el nuevo nombre para el archivo (sin extensión):",
                    "Renombrar archivo",
                    Path.GetFileNameWithoutExtension(archivoActual));

                if (!string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    string nuevoArchivo = Path.Combine(carpeta, nuevoNombre + ".json");

                    if (File.Exists(nuevoArchivo))
                    {
                        MessageBox.Show("Ya existe un archivo con ese nombre. Elige otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        File.Move(archivoActual, nuevoArchivo);
                        MessageBox.Show("Archivo renombrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridViewJuegos.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al renombrar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
