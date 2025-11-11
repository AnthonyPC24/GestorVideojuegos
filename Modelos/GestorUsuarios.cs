using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GestorJuegos.Modelos;
using System.Windows.Forms;

namespace GestorJuegos
{
    public class GestorUsuarios
    {
        private readonly string rutaArchivo = Path.Combine("json", "usuarios.json");

        public List<Usuario> CargarUsuarios()
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show($"No se encontró el archivo: {rutaArchivo}");
                return new List<Usuario>();
            }

            string json = File.ReadAllText(rutaArchivo);

            //Obvia mayúsculas y minúsculas en los nombres de las propiedades
            return JsonSerializer.Deserialize<List<Usuario>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? new List<Usuario>();
        }

        public bool ValidarUsuario(string nombre, string contraseña)
        {
            var usuarios = CargarUsuarios();
            return usuarios.Any(u => u.nombre == nombre && u.contrasena == contraseña);
        }
    }
}


