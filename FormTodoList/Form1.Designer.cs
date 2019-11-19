namespace FormTodoList
{
    partial class frmTarea
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
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.cmdDetalles = new System.Windows.Forms.Button();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(45, 24);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(125, 42);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.Text = "AGREGAR TAREA";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(447, 163);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(125, 42);
            this.cmdEditar.TabIndex = 1;
            this.cmdEditar.Text = "EDITAR ESTATUS";
            this.cmdEditar.UseVisualStyleBackColor = true;
            this.cmdEditar.Click += new System.EventHandler(this.CmdEditar_Click);
            // 
            // cmdDetalles
            // 
            this.cmdDetalles.Location = new System.Drawing.Point(252, 264);
            this.cmdDetalles.Name = "cmdDetalles";
            this.cmdDetalles.Size = new System.Drawing.Size(125, 42);
            this.cmdDetalles.TabIndex = 2;
            this.cmdDetalles.Text = "DETALLES TAREA";
            this.cmdDetalles.UseVisualStyleBackColor = true;
            this.cmdDetalles.Click += new System.EventHandler(this.CmdDetalles_Click);
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(417, 130);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(106, 13);
            this.lblTarea.TabIndex = 3;
            this.lblTarea.Text = "Tarea Seleccionada:";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(417, 103);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(217, 13);
            this.lblDetalles.TabIndex = 5;
            this.lblDetalles.Text = "Selecciona el Estatus que deseas Cambiar...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(45, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Num.";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarea";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estatus";
            this.Column2.Name = "Column2";
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.cmdDetalles);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "frmTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cmdAgregar;
        public System.Windows.Forms.Button cmdEditar;
        public System.Windows.Forms.Button cmdDetalles;
        public System.Windows.Forms.Label lblTarea;
        public System.Windows.Forms.Label lblDetalles;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

