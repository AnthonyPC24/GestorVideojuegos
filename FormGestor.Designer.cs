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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorJuegos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxEstadisticas = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewJuegos = new System.Windows.Forms.DataGridView();
            this.labelAyudas = new System.Windows.Forms.Label();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.groupBoxEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(36, 17);
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
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(776, 538);
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
            this.panelDetalle.Controls.Add(this.pictureBox6);
            this.panelDetalle.Controls.Add(this.labelAyudas);
            this.panelDetalle.Controls.Add(this.linkLabel1);
            this.panelDetalle.Controls.Add(this.chartStats);
            this.panelDetalle.Controls.Add(this.groupBoxEstadisticas);
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
            this.panelDetalle.Size = new System.Drawing.Size(919, 320);
            this.panelDetalle.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(856, 296);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpiar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chartStats
            // 
            this.chartStats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chartStats.BorderlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.Name = "ChartArea1";
            this.chartStats.ChartAreas.Add(chartArea1);
            this.chartStats.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartStats.Legends.Add(legend1);
            this.chartStats.Location = new System.Drawing.Point(492, 71);
            this.chartStats.Name = "chartStats";
            this.chartStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats.Series.Add(series1);
            this.chartStats.Size = new System.Drawing.Size(408, 215);
            this.chartStats.TabIndex = 11;
            this.chartStats.Text = "Stats";
            // 
            // groupBoxEstadisticas
            // 
            this.groupBoxEstadisticas.Controls.Add(this.radioButtonTodos);
            this.groupBoxEstadisticas.Controls.Add(this.radioButton15);
            this.groupBoxEstadisticas.Controls.Add(this.radioButton10);
            this.groupBoxEstadisticas.Controls.Add(this.radioButton5);
            this.groupBoxEstadisticas.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEstadisticas.ForeColor = System.Drawing.Color.White;
            this.groupBoxEstadisticas.Location = new System.Drawing.Point(492, 3);
            this.groupBoxEstadisticas.Name = "groupBoxEstadisticas";
            this.groupBoxEstadisticas.Size = new System.Drawing.Size(408, 56);
            this.groupBoxEstadisticas.TabIndex = 10;
            this.groupBoxEstadisticas.TabStop = false;
            this.groupBoxEstadisticas.Text = " Estadisticas";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(332, 23);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(60, 21);
            this.radioButtonTodos.TabIndex = 3;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Tag = "-1";
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(240, 24);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(40, 21);
            this.radioButton15.TabIndex = 2;
            this.radioButton15.TabStop = true;
            this.radioButton15.Tag = "15";
            this.radioButton15.Text = "15";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(134, 23);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(40, 21);
            this.radioButton10.TabIndex = 1;
            this.radioButton10.TabStop = true;
            this.radioButton10.Tag = "10";
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 23);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(33, 21);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.ForeColor = System.Drawing.Color.White;
            this.labelTiempo.Location = new System.Drawing.Point(319, 159);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(72, 25);
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
            this.labelErrores.Size = new System.Drawing.Size(72, 25);
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
            this.labelPuntuacion.Size = new System.Drawing.Size(108, 25);
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
            this.labelPreguntas.Size = new System.Drawing.Size(98, 25);
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
            this.labelNombre.Size = new System.Drawing.Size(97, 31);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "nombre";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(861, 538);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            this.dataGridViewJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewJuegos.Size = new System.Drawing.Size(919, 150);
            this.dataGridViewJuegos.TabIndex = 6;
            this.dataGridViewJuegos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJuegos_CellEndEdit);
            this.dataGridViewJuegos.SelectionChanged += new System.EventHandler(this.dataGridViewJuegos_SelectionChanged);
            // 
            // labelAyudas
            // 
            this.labelAyudas.AutoSize = true;
            this.labelAyudas.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyudas.ForeColor = System.Drawing.Color.White;
            this.labelAyudas.Location = new System.Drawing.Point(100, 216);
            this.labelAyudas.Name = "labelAyudas";
            this.labelAyudas.Size = new System.Drawing.Size(75, 25);
            this.labelAyudas.TabIndex = 13;
            this.labelAyudas.Text = "Ayudas";
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackgroundImage = global::GestorJuegos.Properties.Resources.settings;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::GestorJuegos.Properties.Resources.settings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(17, 535);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(44, 39);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 13;
            this.pictureBoxSettings.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GestorJuegos.Properties.Resources.ayudas;
            this.pictureBox6.Location = new System.Drawing.Point(17, 201);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewJuegos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRutaArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDetalle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorJuego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorJuegos_FormClosing);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.groupBoxEstadisticas.ResumeLayout(false);
            this.groupBoxEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxEstadisticas;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DataGridView dataGridViewJuegos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelAyudas;
    }
}