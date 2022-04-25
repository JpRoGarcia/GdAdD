namespace Eps.Interfaz
{
    partial class MultaRead
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
            this.btnMultas = new System.Windows.Forms.Button();
            this.txtCedP = new System.Windows.Forms.TextBox();
            this.dgvMulta = new System.Windows.Forms.DataGridView();
            this.btnPagarM = new System.Windows.Forms.Button();
            this.txtIdMulta = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.Cédula = new System.Windows.Forms.Label();
            this.lblIDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMultas
            // 
            this.btnMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.Location = new System.Drawing.Point(171, 28);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(150, 23);
            this.btnMultas.TabIndex = 0;
            this.btnMultas.Text = "Multas Paciente";
            this.btnMultas.UseVisualStyleBackColor = false;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // txtCedP
            // 
            this.txtCedP.Location = new System.Drawing.Point(12, 31);
            this.txtCedP.Name = "txtCedP";
            this.txtCedP.Size = new System.Drawing.Size(150, 20);
            this.txtCedP.TabIndex = 8;
            this.txtCedP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedP_KeyPress);
            // 
            // dgvMulta
            // 
            this.dgvMulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMulta.Location = new System.Drawing.Point(13, 100);
            this.dgvMulta.Name = "dgvMulta";
            this.dgvMulta.Size = new System.Drawing.Size(464, 354);
            this.dgvMulta.TabIndex = 9;
            // 
            // btnPagarM
            // 
            this.btnPagarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnPagarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarM.Location = new System.Drawing.Point(327, 28);
            this.btnPagarM.Name = "btnPagarM";
            this.btnPagarM.Size = new System.Drawing.Size(150, 23);
            this.btnPagarM.TabIndex = 10;
            this.btnPagarM.Text = "Paz y Salvo";
            this.btnPagarM.UseVisualStyleBackColor = false;
            this.btnPagarM.Click += new System.EventHandler(this.btnPagarM_Click);
            // 
            // txtIdMulta
            // 
            this.txtIdMulta.Location = new System.Drawing.Point(12, 73);
            this.txtIdMulta.Name = "txtIdMulta";
            this.txtIdMulta.Size = new System.Drawing.Size(150, 20);
            this.txtIdMulta.TabIndex = 11;
            this.txtIdMulta.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(327, 71);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(150, 23);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Cédula
            // 
            this.Cédula.AutoSize = true;
            this.Cédula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cédula.Location = new System.Drawing.Point(12, 12);
            this.Cédula.Name = "Cédula";
            this.Cédula.Size = new System.Drawing.Size(65, 16);
            this.Cédula.TabIndex = 13;
            this.Cédula.Text = "Cédula: ";
            // 
            // lblIDM
            // 
            this.lblIDM.AutoSize = true;
            this.lblIDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDM.Location = new System.Drawing.Point(12, 54);
            this.lblIDM.Name = "lblIDM";
            this.lblIDM.Size = new System.Drawing.Size(127, 16);
            this.lblIDM.TabIndex = 14;
            this.lblIDM.Text = "Ingresar Id Multa:";
            this.lblIDM.Visible = false;
            // 
            // MultasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.lblIDM);
            this.Controls.Add(this.Cédula);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtIdMulta);
            this.Controls.Add(this.btnPagarM);
            this.Controls.Add(this.dgvMulta);
            this.Controls.Add(this.txtCedP);
            this.Controls.Add(this.btnMultas);
            this.Name = "MultasPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multas Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.TextBox txtCedP;
        private System.Windows.Forms.DataGridView dgvMulta;
        private System.Windows.Forms.Button btnPagarM;
        private System.Windows.Forms.TextBox txtIdMulta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label Cédula;
        private System.Windows.Forms.Label lblIDM;
    }
}