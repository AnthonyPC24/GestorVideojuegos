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
using System.Windows.Forms.DataVisualization.Charting;
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
            dataGridViewJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // columnas se ajustan al ancho
            dataGridViewJuegos.AllowUserToResizeColumns = false; // evita que el usuario cambie tamaño
            dataGridViewJuegos.AllowUserToResizeRows = false;

           
            dataGridViewJuegos.SelectionChanged += dataGridViewJuegos_SelectionChanged;



            radioButton5.CheckedChanged += RadioButtonsEstadisticas_CheckedChanged;
            radioButton10.CheckedChanged += RadioButtonsEstadisticas_CheckedChanged;
            radioButton15.CheckedChanged += RadioButtonsEstadisticas_CheckedChanged;
            radioButtonTodos.CheckedChanged += RadioButtonsEstadisticas_CheckedChanged;

            chartStats.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Montserrat", 10);
            chartStats.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Montserrat", 10);
            chartStats.Legends[0].Font = new Font("Montserrat", 10);

            chartStats.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Ficheros JSON(*.json)|*.json";

            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaArchivo.Text = openFile.FileName;

                string contenidoJson = File.ReadAllText(textBoxRutaArchivo.Text, Encoding.UTF8);
                JArray jarrayJuegos = JArray.Parse(contenidoJson);
                listaJuegos = jarrayJuegos.ToObject<List<Juego>>();

                dataGridViewJuegos.DataSource = listaJuegos;
                dataGridViewJuegos.AutoResizeColumns();
            }
        }

        // Manejar el evento CheckedChanged de los RadioButtons
        private void RadioButtonsEstadisticas_CheckedChanged(object sender, EventArgs e)
        {
            chartStats.Visible = true;

            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                int cantidad = int.Parse(rb.Tag.ToString());
                generarEstadistica(cantidad);
            }
        }

        //Generar estadística de los mejores jugadores
        private void generarEstadistica(int cantidad)
        {
            if (listaJuegos == null || listaJuegos.Count == 0) return;

            // Limpiar gráfico
            chartStats.Series.Clear();
            chartStats.ChartAreas.Clear();

            // Añadir ChartArea
            if (chartStats.ChartAreas.Count == 0)
                chartStats.ChartAreas.Add(new ChartArea());

            // Ordenar por puntuación 
            var datosOrdenados = listaJuegos.OrderByDescending(x => x.puntuacion).ToList();
            List<Juego> juegosParaGraficar = (cantidad == -1) ? datosOrdenados : datosOrdenados.Take(cantidad).ToList();

            // Serie Puntuación
            var seriePuntos = chartStats.Series.Add("Puntuación");
            seriePuntos.ChartType = SeriesChartType.Column;

            // Serie Errores
            var serieErrores = chartStats.Series.Add("Errores");
            serieErrores.ChartType = SeriesChartType.Column;
            serieErrores.Color = Color.Red; // Para diferenciar visualmente

            foreach (var j in juegosParaGraficar)
            {
                seriePuntos.Points.AddXY(j.nombreJugador, j.puntuacion);
                serieErrores.Points.AddXY(j.nombreJugador, j.errores);
            }
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
            labelAyudas.Text = $"Ayudas: {juego.pistasUsadas}";
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
                        dataGridViewJuegos.DataSource = null;
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
                        textBoxRutaArchivo.Text = nuevoArchivo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al renombrar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewJuegos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardaCambiosJson();
        }

        private void GuardaCambiosJson()
        {
            try
            {
                string rutaArchivo = textBoxRutaArchivo.Text;

                if (string.IsNullOrWhiteSpace(rutaArchivo) || !File.Exists(rutaArchivo))
                {
                    MessageBox.Show("Ruta de archivo no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listaJuegos = dataGridViewJuegos.DataSource as List<Juego>;

                string jsonActualizado = Newtonsoft.Json.JsonConvert.SerializeObject(listaJuegos, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(rutaArchivo, jsonActualizado);

                MessageBox.Show("Cambios guardados correctamente en el archivo JSON.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            chartStats.Series.Clear();
            chartStats.Visible = false;
        }

        private void GestorJuegos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
