namespace Eps.Interfaz
{
    partial class CitasPaciente
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
            this.dgvMostarP = new System.Windows.Forms.DataGridView();
            this.txtCedP = new System.Windows.Forms.TextBox();
            this.BuscarC = new System.Windows.Forms.Button();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.btnAsisitio = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNoAsistio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostarP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostarP
            // 
            this.dgvMostarP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvMostarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostarP.Location = new System.Drawing.Point(12, 101);
            this.dgvMostarP.Name = "dgvMostarP";
            this.dgvMostarP.Size = new System.Drawing.Size(465, 353);
            this.dgvMostarP.TabIndex = 0;
            // 
            // txtCedP
            // 
            this.txtCedP.Location = new System.Drawing.Point(12, 28);
            this.txtCedP.Name = "txtCedP";
            this.txtCedP.Size = new System.Drawing.Size(150, 20);
            this.txtCedP.TabIndex = 7;
            this.txtCedP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedP_KeyPress);
            // 
            // BuscarC
            // 
            this.BuscarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.BuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarC.Location = new System.Drawing.Point(171, 28);
            this.BuscarC.Name = "BuscarC";
            this.BuscarC.Size = new System.Drawing.Size(150, 25);
            this.BuscarC.TabIndex = 6;
            this.BuscarC.Text = "Buscar Citas";
            this.BuscarC.UseVisualStyleBackColor = false;
            this.BuscarC.Click += new System.EventHandler(this.BuscarC_Click);
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(12, 70);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(150, 20);
            this.txtIdC.TabIndex = 8;
            this.txtIdC.Visible = false;
            // 
            // btnAsisitio
            // 
            this.btnAsisitio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            this.btnAsisitio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsisitio.Location = new System.Drawing.Point(171, 70);
            this.btnAsisitio.Name = "btnAsisitio";
            this.btnAsisitio.Size = new System.Drawing.Size(95, 25);
            this.btnAsisitio.TabIndex = 9;
            this.btnAsisitio.Text = "Asistio Cita";
            this.btnAsisitio.UseVisualStyleBackColor = false;
            this.btnAsisitio.Visible = false;
            this.btnAsisitio.Click += new System.EventHandler(this.btnAsisitio_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(327, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 25);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Estado Cita";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNoAsistio
            // 
            this.btnNoAsistio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNoAsistio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoAsistio.Location = new System.Drawing.Point(272, 70);
            this.btnNoAsistio.Name = "btnNoAsistio";
            this.btnNoAsistio.Size = new System.Drawing.Size(95, 25);
            this.btnNoAsistio.TabIndex = 11;
            this.btnNoAsistio.Text = "No Asistio Cita";
            this.btnNoAsistio.UseVisualStyleBackColor = false;
            this.btnNoAsistio.Visible = false;
            this.btnNoAsistio.Click += new System.EventHandler(this.btnNoAsistio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cédula Paciente: ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(12, 51);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(155, 16);
            this.lbId.TabIndex = 13;
            this.lbId.Text = "Ingrese Id de la Cita: ";
            this.lbId.Visible = false;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(133)))));
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(373, 70);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 25);
            this.cancelar.TabIndex = 14;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CitasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNoAsistio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAsisitio);
            this.Controls.Add(this.txtIdC);
            this.Controls.Add(this.txtCedP);
            this.Controls.Add(this.BuscarC);
            this.Controls.Add(this.dgvMostarP);
            this.Name = "CitasPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostarP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostarP;
        private System.Windows.Forms.TextBox txtCedP;
        private System.Windows.Forms.Button BuscarC;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.Button btnAsisitio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNoAsistio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button cancelar;
    }
}