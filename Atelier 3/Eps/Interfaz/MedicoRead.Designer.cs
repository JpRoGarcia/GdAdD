
namespace Eps.Interfaz
{
    partial class MedicoRead
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
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.lvlcedulaM = new System.Windows.Forms.Label();
            this.btnMostrarM = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtCedM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnEliminarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(255, 20);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(222, 23);
            this.btnEliminarM.TabIndex = 28;
            this.btnEliminarM.Text = "Eliminar Médicos";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // lvlcedulaM
            // 
            this.lvlcedulaM.AutoSize = true;
            this.lvlcedulaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcedulaM.Location = new System.Drawing.Point(12, 46);
            this.lvlcedulaM.Name = "lvlcedulaM";
            this.lvlcedulaM.Size = new System.Drawing.Size(65, 16);
            this.lvlcedulaM.TabIndex = 27;
            this.lvlcedulaM.Text = "Cédula: ";
            this.lvlcedulaM.Visible = false;
            // 
            // btnMostrarM
            // 
            this.btnMostrarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnMostrarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarM.Location = new System.Drawing.Point(12, 20);
            this.btnMostrarM.Name = "btnMostrarM";
            this.btnMostrarM.Size = new System.Drawing.Size(222, 23);
            this.btnMostrarM.TabIndex = 26;
            this.btnMostrarM.Text = "Mostrar Médicos";
            this.btnMostrarM.UseVisualStyleBackColor = false;
            this.btnMostrarM.Click += new System.EventHandler(this.btnMostrarM_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(252, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(13, 92);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(464, 354);
            this.dgvPacientes.TabIndex = 24;
            // 
            // txtCedM
            // 
            this.txtCedM.Location = new System.Drawing.Point(12, 65);
            this.txtCedM.Name = "txtCedM";
            this.txtCedM.Size = new System.Drawing.Size(225, 20);
            this.txtCedM.TabIndex = 23;
            this.txtCedM.Visible = false;
            // 
            // MedicoRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.lvlcedulaM);
            this.Controls.Add(this.btnMostrarM);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtCedM);
            this.Name = "MedicoRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Label lvlcedulaM;
        private System.Windows.Forms.Button btnMostrarM;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txtCedM;
    }
}