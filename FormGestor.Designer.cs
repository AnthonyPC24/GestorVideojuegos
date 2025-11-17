namespace GestorJuegos
{
    partial class GestorJuegos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorJuegos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewJuegos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).BeginInit();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta";
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(50, 12);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(209, 20);
            this.textBoxRutaArchivo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewJuegos
            // 
            this.dataGridViewJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJuegos.Location = new System.Drawing.Point(17, 39);
            this.dataGridViewJuegos.Name = "dataGridViewJuegos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJuegos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJuegos.Size = new System.Drawing.Size(838, 150);
            this.dataGridViewJuegos.TabIndex = 6;
            this.dataGridViewJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJuegos_CellContentClick);
            this.dataGridViewJuegos.SelectionChanged += new System.EventHandler(this.dataGridViewJuegos_SelectionChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(697, 484);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalle.Controls.Add(this.pictureBox5);
            this.panelDetalle.Controls.Add(this.pictureBox4);
            this.panelDetalle.Controls.Add(this.pictureBox3);
            this.panelDetalle.Controls.Add(this.pictureBox2);
            this.panelDetalle.Controls.Add(this.pictureBox1);
            this.panelDetalle.Controls.Add(this.labelTiempo);
            this.panelDetalle.Controls.Add(this.labelErrores);
            this.panelDetalle.Controls.Add(this.labelPuntuacion);
            this.panelDetalle.Controls.Add(this.labelPreguntas);
            this.panelDetalle.Controls.Add(this.labelNombre);
            this.panelDetalle.Location = new System.Drawing.Point(17, 209);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(838, 269);
            this.panelDetalle.TabIndex = 8;
            this.panelDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetalle_Paint);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.ForeColor = System.Drawing.Color.White;
            this.labelTiempo.Location = new System.Drawing.Point(319, 159);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(73, 25);
            this.labelTiempo.TabIndex = 4;
            this.labelTiempo.Text = "tiempo";
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrores.ForeColor = System.Drawing.Color.White;
            this.labelErrores.Location = new System.Drawing.Point(102, 159);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(73, 25);
            this.labelErrores.TabIndex = 3;
            this.labelErrores.Text = "errores";
            // 
            // labelPuntuacion
            // 
            this.labelPuntuacion.AutoSize = true;
            this.labelPuntuacion.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuacion.ForeColor = System.Drawing.Color.White;
            this.labelPuntuacion.Location = new System.Drawing.Point(319, 96);
            this.labelPuntuacion.Name = "labelPuntuacion";
            this.labelPuntuacion.Size = new System.Drawing.Size(110, 25);
            this.labelPuntuacion.TabIndex = 2;
            this.labelPuntuacion.Text = "puntuación";
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreguntas.ForeColor = System.Drawing.Color.White;
            this.labelPreguntas.Location = new System.Drawing.Point(101, 96);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(99, 25);
            this.labelPreguntas.TabIndex = 1;
            this.labelPreguntas.Text = "preguntas";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(101, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(98, 31);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "nombre";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(780, 484);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GestorJuegos.Properties.Resources.tiempo_rapido;
            this.pictureBox5.Location = new System.Drawing.Point(234, 147);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(88, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestorJuegos.Properties.Resources.maquina_de_arcade;
            this.pictureBox4.Location = new System.Drawing.Point(17, 147);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestorJuegos.Properties.Resources.puntuacion_mas_alta;
            this.pictureBox3.Location = new System.Drawing.Point(234, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestorJuegos.Properties.Resources.juego_de_preguntas;
            this.pictureBox2.Location = new System.Drawing.Point(17, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestorJuegos.Properties.Resources.tarjetas;
            this.pictureBox1.Location = new System.Drawing.Point(17, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GestorJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(867, 517);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewJuegos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRutaArchivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorJuego";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewJuegos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Label labelPuntuacion;
        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}