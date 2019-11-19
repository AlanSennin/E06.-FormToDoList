namespace FormTodoList
{
    partial class Edit
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
            this.cmdCambiar = new System.Windows.Forms.Button();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtEstatusEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCambiar
            // 
            this.cmdCambiar.Location = new System.Drawing.Point(93, 106);
            this.cmdCambiar.Name = "cmdCambiar";
            this.cmdCambiar.Size = new System.Drawing.Size(154, 43);
            this.cmdCambiar.TabIndex = 0;
            this.cmdCambiar.Text = "CERRAR";
            this.cmdCambiar.UseVisualStyleBackColor = true;
            this.cmdCambiar.Click += new System.EventHandler(this.CmdCambiar_Click);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(35, 47);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(118, 13);
            this.lblEstatus.TabIndex = 2;
            this.lblEstatus.Text = "Ingrese Nuevo Estatus:";
            // 
            // txtEstatusEdit
            // 
            this.txtEstatusEdit.Location = new System.Drawing.Point(159, 47);
            this.txtEstatusEdit.Name = "txtEstatusEdit";
            this.txtEstatusEdit.Size = new System.Drawing.Size(136, 20);
            this.txtEstatusEdit.TabIndex = 4;
            // 
            // Edit
            // 
            this.AcceptButton = this.cmdCambiar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 178);
            this.Controls.Add(this.txtEstatusEdit);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.cmdCambiar);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCambiar;
        private System.Windows.Forms.Label lblEstatus;
        public System.Windows.Forms.TextBox txtEstatusEdit;
    }
}