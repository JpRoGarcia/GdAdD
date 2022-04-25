namespace Eps.Interfaz
{
    partial class MedicoValor
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
            this.txtCedM = new System.Windows.Forms.TextBox();
            this.dtvValorM = new System.Windows.Forms.DataGridView();
            this.BuscarValor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvValorM)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedM
            // 
            this.txtCedM.Location = new System.Drawing.Point(15, 28);
            this.txtCedM.Name = "txtCedM";
            this.txtCedM.Size = new System.Drawing.Size(150, 20);
            this.txtCedM.TabIndex = 5;
            this.txtCedM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedM_KeyPress);
            // 
            // dtvValorM
            // 
            this.dtvValorM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dtvValorM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvValorM.Location = new System.Drawing.Point(12, 57);
            this.dtvValorM.Name = "dtvValorM";
            this.dtvValorM.Size = new System.Drawing.Size(464, 397);
            this.dtvValorM.TabIndex = 4;
            // 
            // BuscarValor
            // 
            this.BuscarValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.BuscarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarValor.Location = new System.Drawing.Point(326, 28);
            this.BuscarValor.Name = "BuscarValor";
            this.BuscarValor.Size = new System.Drawing.Size(150, 23);
            this.BuscarValor.TabIndex = 3;
            this.BuscarValor.Text = "Buscar Valor";
            this.BuscarValor.UseVisualStyleBackColor = false;
            this.BuscarValor.Click += new System.EventHandler(this.BuscarValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cédula: ";
            // 
            // ValorMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedM);
            this.Controls.Add(this.dtvValorM);
            this.Controls.Add(this.BuscarValor);
            this.Name = "ValorMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor Cita Medico";
            ((System.ComponentModel.ISupportInitialize)(this.dtvValorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedM;
        private System.Windows.Forms.DataGridView dtvValorM;
        private System.Windows.Forms.Button BuscarValor;
        private System.Windows.Forms.Label label1;
    }
}