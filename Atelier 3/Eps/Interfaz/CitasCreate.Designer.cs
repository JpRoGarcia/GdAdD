namespace Eps.Interfaz
{
    partial class CitasCreate
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
            this.cFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cFechaCita
            // 
            this.cFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cFechaCita.Location = new System.Drawing.Point(140, 270);
            this.cFechaCita.Name = "cFechaCita";
            this.cFechaCita.Size = new System.Drawing.Size(200, 20);
            this.cFechaCita.TabIndex = 57;
            this.cFechaCita.Value = new System.DateTime(2020, 11, 13, 1, 40, 25, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Cédula Paciente: ";
            // 
            // txtIdPc
            // 
            this.txtIdPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPc.Location = new System.Drawing.Point(140, 182);
            this.txtIdPc.Name = "txtIdPc";
            this.txtIdPc.Size = new System.Drawing.Size(200, 22);
            this.txtIdPc.TabIndex = 58;
            this.txtIdPc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tipo de CIta: \r\n";
            // 
            // cbCita
            // 
            this.cbCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCita.FormattingEnabled = true;
            this.cbCita.Items.AddRange(new object[] {
            "",
            "Médico General",
            "Optómetra",
            "Pediatra"});
            this.cbCita.Location = new System.Drawing.Point(140, 134);
            this.cbCita.Name = "cbCita";
            this.cbCita.Size = new System.Drawing.Size(200, 24);
            this.cbCita.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cédula Medico: ";
            // 
            // txtIdMc
            // 
            this.txtIdMc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMc.Location = new System.Drawing.Point(140, 226);
            this.txtIdMc.Name = "txtIdMc";
            this.txtIdMc.Size = new System.Drawing.Size(200, 22);
            this.txtIdMc.TabIndex = 62;
            this.txtIdMc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Fecha Cita: ";
            // 
            // btnRCita
            // 
            this.btnRCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnRCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCita.Location = new System.Drawing.Point(159, 334);
            this.btnRCita.Name = "btnRCita";
            this.btnRCita.Size = new System.Drawing.Size(150, 25);
            this.btnRCita.TabIndex = 65;
            this.btnRCita.Text = "Registrar Cita";
            this.btnRCita.UseVisualStyleBackColor = false;
            this.btnRCita.Click += new System.EventHandler(this.btnRCita_Click);
            // 
            // RCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.btnRCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdMc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdPc);
            this.Controls.Add(this.cFechaCita);
            this.Name = "RCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Citas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cFechaCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRCita;
    }
}