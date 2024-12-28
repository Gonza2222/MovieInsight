namespace pryMovieInsight
{
    partial class frmVisualizacionesGenero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVisMin = new System.Windows.Forms.Label();
            this.lblVisMax = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvVisualizaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisMin
            // 
            this.lblVisMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisMin.Location = new System.Drawing.Point(301, 600);
            this.lblVisMin.Name = "lblVisMin";
            this.lblVisMin.Size = new System.Drawing.Size(108, 28);
            this.lblVisMin.TabIndex = 22;
            this.lblVisMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVisMax
            // 
            this.lblVisMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisMax.Location = new System.Drawing.Point(301, 548);
            this.lblVisMax.Name = "lblVisMax";
            this.lblVisMax.Size = new System.Drawing.Size(108, 28);
            this.lblVisMax.TabIndex = 21;
            this.lblVisMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(301, 490);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(108, 28);
            this.lblPromedio.TabIndex = 20;
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Location = new System.Drawing.Point(301, 434);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 28);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Visualizaciones mínimas:";
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(121, 666);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(244, 49);
            this.cmdListar.TabIndex = 17;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvVisualizaciones
            // 
            this.dgvVisualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvVisualizaciones.Location = new System.Drawing.Point(60, 86);
            this.dgvVisualizaciones.Name = "dgvVisualizaciones";
            this.dgvVisualizaciones.Size = new System.Drawing.Size(349, 321);
            this.dgvVisualizaciones.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mes";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Promedio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Visualizaciones máximas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad de visualizaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Género:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(187, 32);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(222, 27);
            this.cmbGenero.TabIndex = 11;
            // 
            // frmVisualizacionesGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(469, 727);
            this.Controls.Add(this.lblVisMin);
            this.Controls.Add(this.lblVisMax);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvVisualizaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVisualizacionesGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizaciones de un género";
            this.Load += new System.EventHandler(this.frmVisualizacionesGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisMin;
        private System.Windows.Forms.Label lblVisMax;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvVisualizaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}