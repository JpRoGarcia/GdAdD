namespace Eps.Interfaz
{
    partial class UpdatePaciente
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelP = new System.Windows.Forms.TextBox();
            this.txtDirP = new System.Windows.Forms.TextBox();
            this.txtEmailP = new System.Windows.Forms.TextBox();
            this.txtCedP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Actulizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelP
            // 
            this.txtTelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelP.Location = new System.Drawing.Point(109, 274);
            this.txtTelP.Name = "txtTelP";
            this.txtTelP.Size = new System.Drawing.Size(250, 22);
            this.txtTelP.TabIndex = 16;
            this.txtTelP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelP_KeyPress);
            // 
            // txtDirP
            // 
            this.txtDirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirP.Location = new System.Drawing.Point(109, 230);
            this.txtDirP.Name = "txtDirP";
            this.txtDirP.Size = new System.Drawing.Size(250, 22);
            this.txtDirP.TabIndex = 15;
            // 
            // txtEmailP
            // 
            this.txtEmailP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailP.Location = new System.Drawing.Point(109, 186);
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Size = new System.Drawing.Size(250, 22);
            this.txtEmailP.TabIndex = 13;
            // 
            // txtCedP
            // 
            this.txtCedP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedP.Location = new System.Drawing.Point(109, 142);
            this.txtCedP.Name = "txtCedP";
            this.txtCedP.Size = new System.Drawing.Size(250, 22);
            this.txtCedP.TabIndex = 10;
            this.txtCedP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cédula: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teléfono: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dirección: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email: ";
            // 
            // UpdatePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTelP);
            this.Controls.Add(this.txtDirP);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.txtCedP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UpdatePaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTelP;
        private System.Windows.Forms.TextBox txtDirP;
        private System.Windows.Forms.TextBox txtEmailP;
        private System.Windows.Forms.TextBox txtCedP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}