namespace GestorJuegos
{
    partial class FormGestor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewJuegos = new System.Windows.Forms.DataGridView();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).BeginInit();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
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
            this.dataGridViewJuegos.Size = new System.Drawing.Size(838, 150);
            this.dataGridViewJuegos.TabIndex = 6;
            this.dataGridViewJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJuegos_CellContentClick);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(634, 526);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.chart1);
            this.panelDetalle.Controls.Add(this.labelTiempo);
            this.panelDetalle.Controls.Add(this.labelErrores);
            this.panelDetalle.Controls.Add(this.labelPuntuacion);
            this.panelDetalle.Controls.Add(this.labelPreguntas);
            this.panelDetalle.Controls.Add(this.labelNombre);
            this.panelDetalle.Location = new System.Drawing.Point(17, 209);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(838, 300);
            this.panelDetalle.TabIndex = 8;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(15, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "label2";
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Location = new System.Drawing.Point(15, 43);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(35, 13);
            this.labelPreguntas.TabIndex = 1;
            this.labelPreguntas.Text = "label2";
            // 
            // labelPuntuacion
            // 
            this.labelPuntuacion.AutoSize = true;
            this.labelPuntuacion.Location = new System.Drawing.Point(105, 43);
            this.labelPuntuacion.Name = "labelPuntuacion";
            this.labelPuntuacion.Size = new System.Drawing.Size(35, 13);
            this.labelPuntuacion.TabIndex = 2;
            this.labelPuntuacion.Text = "label2";
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(193, 43);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(35, 13);
            this.labelErrores.TabIndex = 3;
            this.labelErrores.Text = "label2";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(290, 42);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(35, 13);
            this.labelTiempo.TabIndex = 4;
            this.labelTiempo.Text = "label2";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 78);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(320, 199);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // FormGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 552);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewJuegos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRutaArchivo);
            this.Controls.Add(this.label1);
            this.Name = "FormGestor";
            this.Text = "FormGestor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewJuegos;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Label labelPuntuacion;
        private System.Windows.Forms.Label labelPreguntas;
    }
}