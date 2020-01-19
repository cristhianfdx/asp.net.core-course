namespace capaPresentacion
{
    partial class FormEstudiante
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
            this.dGviewEstudiantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCarrera = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckBoxDanza = new System.Windows.Forms.CheckBox();
            this.ckBoxTeatro = new System.Windows.Forms.CheckBox();
            this.ckBoxMusica = new System.Windows.Forms.CheckBox();
            this.ckBoxDeportes = new System.Windows.Forms.CheckBox();
            this.rBMasculino = new System.Windows.Forms.RadioButton();
            this.rBFemenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGviewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGviewEstudiantes
            // 
            this.dGviewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGviewEstudiantes.Location = new System.Drawing.Point(50, 344);
            this.dGviewEstudiantes.Name = "dGviewEstudiantes";
            this.dGviewEstudiantes.Size = new System.Drawing.Size(567, 203);
            this.dGviewEstudiantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTUDIANTES";
            // 
            // cBoxCarrera
            // 
            this.cBoxCarrera.FormattingEnabled = true;
            this.cBoxCarrera.Location = new System.Drawing.Point(148, 196);
            this.cBoxCarrera.Name = "cBoxCarrera";
            this.cBoxCarrera.Size = new System.Drawing.Size(121, 21);
            this.cBoxCarrera.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(148, 123);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CARRERA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "INTERESES:";
            // 
            // ckBoxDanza
            // 
            this.ckBoxDanza.AutoSize = true;
            this.ckBoxDanza.Location = new System.Drawing.Point(60, 288);
            this.ckBoxDanza.Name = "ckBoxDanza";
            this.ckBoxDanza.Size = new System.Drawing.Size(63, 17);
            this.ckBoxDanza.TabIndex = 7;
            this.ckBoxDanza.Text = "DANZA";
            this.ckBoxDanza.UseVisualStyleBackColor = true;
            // 
            // ckBoxTeatro
            // 
            this.ckBoxTeatro.AutoSize = true;
            this.ckBoxTeatro.Location = new System.Drawing.Point(148, 288);
            this.ckBoxTeatro.Name = "ckBoxTeatro";
            this.ckBoxTeatro.Size = new System.Drawing.Size(70, 17);
            this.ckBoxTeatro.TabIndex = 8;
            this.ckBoxTeatro.Text = "TEATRO";
            this.ckBoxTeatro.UseVisualStyleBackColor = true;
            // 
            // ckBoxMusica
            // 
            this.ckBoxMusica.AutoSize = true;
            this.ckBoxMusica.Location = new System.Drawing.Point(234, 288);
            this.ckBoxMusica.Name = "ckBoxMusica";
            this.ckBoxMusica.Size = new System.Drawing.Size(67, 17);
            this.ckBoxMusica.TabIndex = 9;
            this.ckBoxMusica.Text = "MÚSICA";
            this.ckBoxMusica.UseVisualStyleBackColor = true;
            // 
            // ckBoxDeportes
            // 
            this.ckBoxDeportes.AutoSize = true;
            this.ckBoxDeportes.Location = new System.Drawing.Point(322, 288);
            this.ckBoxDeportes.Name = "ckBoxDeportes";
            this.ckBoxDeportes.Size = new System.Drawing.Size(85, 17);
            this.ckBoxDeportes.TabIndex = 10;
            this.ckBoxDeportes.Text = "DEPORTES";
            this.ckBoxDeportes.UseVisualStyleBackColor = true;
            // 
            // rBMasculino
            // 
            this.rBMasculino.AutoSize = true;
            this.rBMasculino.Location = new System.Drawing.Point(148, 161);
            this.rBMasculino.Name = "rBMasculino";
            this.rBMasculino.Size = new System.Drawing.Size(88, 17);
            this.rBMasculino.TabIndex = 11;
            this.rBMasculino.TabStop = true;
            this.rBMasculino.Text = "MASCULINO";
            this.rBMasculino.UseVisualStyleBackColor = true;
            // 
            // rBFemenino
            // 
            this.rBFemenino.AutoSize = true;
            this.rBFemenino.Location = new System.Drawing.Point(266, 161);
            this.rBFemenino.Name = "rBFemenino";
            this.rBFemenino.Size = new System.Drawing.Size(81, 17);
            this.rBFemenino.TabIndex = 12;
            this.rBFemenino.TabStop = true;
            this.rBFemenino.Text = "FEMENINO";
            this.rBFemenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "GÉNERO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(148, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CÓDIGO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "NOMBRE:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(488, 49);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "INSERTAR";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "MODIFICAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(488, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(488, 166);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 22;
            this.btnClean.Text = "LIMPIAR";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(488, 231);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 23;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 559);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rBFemenino);
            this.Controls.Add(this.rBMasculino);
            this.Controls.Add(this.ckBoxDeportes);
            this.Controls.Add(this.ckBoxMusica);
            this.Controls.Add(this.ckBoxTeatro);
            this.Controls.Add(this.ckBoxDanza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.cBoxCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGviewEstudiantes);
            this.Name = "FormEstudiante";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGviewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGviewEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCarrera;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckBoxDanza;
        private System.Windows.Forms.CheckBox ckBoxTeatro;
        private System.Windows.Forms.CheckBox ckBoxMusica;
        private System.Windows.Forms.CheckBox ckBoxDeportes;
        private System.Windows.Forms.RadioButton rBMasculino;
        private System.Windows.Forms.RadioButton rBFemenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtId;
    }
}

