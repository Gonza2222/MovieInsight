namespace pryMovieInsight
{
    partial class frmListadoGeneralGeneros
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
            this.dgvListadoGén = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGénCar = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGén)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoGén
            // 
            this.dgvListadoGén.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoGén.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListadoGén.Location = new System.Drawing.Point(27, 13);
            this.dgvListadoGén.Name = "dgvListadoGén";
            this.dgvListadoGén.Size = new System.Drawing.Size(1078, 276);
            this.dgvListadoGén.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de géneros cargados:";
            // 
            // lblGénCar
            // 
            this.lblGénCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGénCar.Location = new System.Drawing.Point(709, 376);
            this.lblGénCar.Name = "lblGénCar";
            this.lblGénCar.Size = new System.Drawing.Size(214, 30);
            this.lblGénCar.TabIndex = 2;
            this.lblGénCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(462, 448);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(230, 58);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.Width = 800;
            // 
            // frmListadoGeneralGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1130, 538);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.lblGénCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListadoGén);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmListadoGeneralGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado general de géneros...";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGén)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoGén;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGénCar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}