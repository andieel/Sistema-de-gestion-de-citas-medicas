namespace Sistema_de_gestion_de_citas_medicas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCita = new System.Windows.Forms.DateTimePicker();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenarFecha = new System.Windows.Forms.Button();
            this.buttonOrdenarDoctor = new System.Windows.Forms.Button();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de la cita";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(150, 24);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(485, 24);
            this.comboBoxDoctor.TabIndex = 6;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(150, 73);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(485, 24);
            this.comboBoxPaciente.TabIndex = 7;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(150, 124);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerFecha.TabIndex = 8;
            // 
            // dateTimePickerCita
            // 
            this.dateTimePickerCita.Location = new System.Drawing.Point(150, 180);
            this.dateTimePickerCita.Name = "dateTimePickerCita";
            this.dateTimePickerCita.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerCita.TabIndex = 9;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(268, 229);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(263, 32);
            this.buttonRegistrar.TabIndex = 10;
            this.buttonRegistrar.Text = "Registrar Cita";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 238);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(434, 297);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(201, 35);
            this.buttonMostrar.TabIndex = 12;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenarFecha
            // 
            this.buttonOrdenarFecha.Location = new System.Drawing.Point(434, 370);
            this.buttonOrdenarFecha.Name = "buttonOrdenarFecha";
            this.buttonOrdenarFecha.Size = new System.Drawing.Size(201, 35);
            this.buttonOrdenarFecha.TabIndex = 13;
            this.buttonOrdenarFecha.Text = "Ordenar por Fecha";
            this.buttonOrdenarFecha.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenarDoctor
            // 
            this.buttonOrdenarDoctor.Location = new System.Drawing.Point(434, 431);
            this.buttonOrdenarDoctor.Name = "buttonOrdenarDoctor";
            this.buttonOrdenarDoctor.Size = new System.Drawing.Size(201, 35);
            this.buttonOrdenarDoctor.TabIndex = 14;
            this.buttonOrdenarDoctor.Text = "OrdenarDoctor";
            this.buttonOrdenarDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.Location = new System.Drawing.Point(434, 500);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(201, 35);
            this.buttonEstadisticas.TabIndex = 15;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 556);
            this.Controls.Add(this.buttonEstadisticas);
            this.Controls.Add(this.buttonOrdenarDoctor);
            this.Controls.Add(this.buttonOrdenarFecha);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.dateTimePickerCita);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerCita;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenarFecha;
        private System.Windows.Forms.Button buttonOrdenarDoctor;
        private System.Windows.Forms.Button buttonEstadisticas;
    }
}

