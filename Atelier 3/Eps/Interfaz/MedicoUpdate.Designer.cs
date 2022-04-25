namespace Eps.Interfaz
{
    partial class UpdateMedico
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActualizarM = new System.Windows.Forms.Button();
            this.txtSalMA = new System.Windows.Forms.TextBox();
            this.txtNomMA = new System.Windows.Forms.TextBox();
            this.txtCedMA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Salario por Cita: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cédula: ";
            // 
            // ActualizarM
            // 
            this.ActualizarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.ActualizarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarM.Location = new System.Drawing.Point(149, 305);
            this.ActualizarM.Name = "ActualizarM";
            this.ActualizarM.Size = new System.Drawing.Size(175, 25);
            this.ActualizarM.TabIndex = 31;
            this.ActualizarM.Text = "Actualizar";
            this.ActualizarM.UseVisualStyleBackColor = false;
            this.ActualizarM.Click += new System.EventHandler(this.ActualizarM_Click);
            // 
            // txtSalMA
            // 
            this.txtSalMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalMA.Location = new System.Drawing.Point(114, 234);
            this.txtSalMA.Name = "txtSalMA";
            this.txtSalMA.Size = new System.Drawing.Size(250, 22);
            this.txtSalMA.TabIndex = 30;
            this.txtSalMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalMA_KeyPress);
            // 
            // txtNomMA
            // 
            this.txtNomMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMA.Location = new System.Drawing.Point(114, 195);
            this.txtNomMA.Name = "txtNomMA";
            this.txtNomMA.Size = new System.Drawing.Size(250, 22);
            this.txtNomMA.TabIndex = 29;
            this.txtNomMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomMA_KeyPress);
            // 
            // txtCedMA
            // 
            this.txtCedMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedMA.Location = new System.Drawing.Point(114, 156);
            this.txtCedMA.Name = "txtCedMA";
            this.txtCedMA.Size = new System.Drawing.Size(250, 22);
            this.txtCedMA.TabIndex = 28;
            this.txtCedMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedMA_KeyPress);
            // 
            // UpdateMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActualizarM);
            this.Controls.Add(this.txtSalMA);
            this.Controls.Add(this.txtNomMA);
            this.Controls.Add(this.txtCedMA);
            this.Name = "UpdateMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActualizarM;
        private System.Windows.Forms.TextBox txtSalMA;
        private System.Windows.Forms.TextBox txtNomMA;
        private System.Windows.Forms.TextBox txtCedMA;
    }
}