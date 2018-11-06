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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDia = new System.Windows.Forms.Label();
            this.dataGridDia = new System.Windows.Forms.DataGridView();
            this.musculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ejercicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTextoDia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridDia.AllowUserToAddRows = false;
            this.dataGridDia.AllowUserToResizeColumns = false;
            this.dataGridDia.AllowUserToResizeRows = false;
            this.dataGridDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musculo,
            this.ejercicio,
            this.serie,
            this.repeticion,
            this.descanso,
            this.observacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDia.EnableHeadersVisualStyles = false;
            this.dataGridDia.Location = new System.Drawing.Point(18, 55);
            this.dataGridDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 10);
            this.dataGridDia.MultiSelect = false;
            this.dataGridDia.Name = "dataGridDia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDia.RowHeadersVisible = false;
            this.dataGridDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridDia.Size = new System.Drawing.Size(744, 22);
            this.dataGridDia.TabIndex = 2;
            this.dataGridDia.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridDia_RowsAdded);
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::GimnasioApp.Properties.Resources.icons8_Borrar_32;
            this.button3.Location = new System.Drawing.Point(752, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::GimnasioApp.Properties.Resources.icons8_Cancel_32;
            this.button2.Location = new System.Drawing.Point(686, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::GimnasioApp.Properties.Resources.icons8_Plus_32;
            this.button1.Location = new System.Drawing.Point(642, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridDiaRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTextoDia);
            this.Controls.Add(this.dataGridDia);
            this.Controls.Add(this.lblDia);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.Name = "DataGridDiaRutina";
            this.Size = new System.Drawing.Size(781, 131);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
