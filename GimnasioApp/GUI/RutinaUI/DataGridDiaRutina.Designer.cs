namespace GimnasioApp.GUI.RutinaUI
{
    partial class DataGridDiaRutina
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDia = new System.Windows.Forms.Label();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            this.lblTextoDia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ejercicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(14, 24);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(40, 21);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia:";
            // 
            // dataGridDia
            // 
            this.dataGridDia.AllowUserToResizeColumns = false;
            this.dataGridDia.AllowUserToResizeRows = false;
            this.dataGridDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musculo,
            this.ejercicio,
            this.serie,
            this.repeticion,
            this.descanso,
            this.observacion});
            this.dataGridDia.Location = new System.Drawing.Point(18, 55);
            this.dataGridDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDia.MultiSelect = false;
            this.dataGridDia.Name = "dataGridDia";
            this.dataGridDia.RowHeadersVisible = false;
            this.dataGridDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridDia.Size = new System.Drawing.Size(510, 50);
            this.dataGridDia.TabIndex = 2;
            this.dataGridDia.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridDia_RowsAdded);
            // 
            // lblTextoDia
            // 
            this.lblTextoDia.AutoSize = true;
            this.lblTextoDia.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDia.Location = new System.Drawing.Point(51, 25);
            this.lblTextoDia.Name = "lblTextoDia";
            this.lblTextoDia.Size = new System.Drawing.Size(28, 21);
            this.lblTextoDia.TabIndex = 3;
            this.lblTextoDia.Text = "01";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "-  Nombre:";
            // 
            // musculo
            // 
            this.musculo.HeaderText = "Musculo";
            this.musculo.Name = "musculo";
            this.musculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.musculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ejercicio
            // 
            this.ejercicio.HeaderText = "Ejercicio";
            this.ejercicio.Name = "ejercicio";
            // 
            // serie
            // 
            this.serie.HeaderText = "Series";
            this.serie.Name = "serie";
            this.serie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.serie.Width = 60;
            // 
            // repeticion
            // 
            this.repeticion.HeaderText = "Repeticiones";
            this.repeticion.Name = "repeticion";
            this.repeticion.Width = 90;
            // 
            // descanso
            // 
            this.descanso.HeaderText = "Descanso";
            this.descanso.Name = "descanso";
            this.descanso.Width = 70;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacion.HeaderText = "Observaciones";
            this.observacion.Name = "observacion";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(422, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Ejercicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridDiaRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTextoDia);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.lblDia);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataGridDiaRutina";
            this.Size = new System.Drawing.Size(581, 118);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.DataGridView dataGridDia;
        private System.Windows.Forms.Label lblTextoDia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn musculo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.Button button1;
    }
}
