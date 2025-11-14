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

namespace GestorJuegos
{
    public partial class FormGestor : Form

    {
        List<Juego> listaJuegos;

        public FormGestor()
        {
            InitializeComponent();
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
            if (dataGridViewJuegos.CurrentRow != null)
            {
                var juego = (Juego)dataGridViewJuegos.CurrentRow.DataBoundItem;

                if (!String.IsNullOrEmpty(juego.avatar) && File.Exists(juego.avatar))
                {

                }
            }
        }

    }
}
