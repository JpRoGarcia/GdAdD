
namespace Eps.Interfaz
{
    partial class PacienteRead
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
            this.lvlcedula = new System.Windows.Forms.Label();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtCedP = new System.Windows.Forms.TextBox();
            this.btnEliminarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlcedula
            // 
            this.lvlcedula.AutoSize = true;
            this.lvlcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcedula.Location = new System.Drawing.Point(12, 54);
            this.lvlcedula.Name = "lvlcedula";
            this.lvlcedula.Size = new System.Drawing.Size(65, 16);
            this.lvlcedula.TabIndex = 21;
            this.lvlcedula.Text = "Cédula: ";
            this.lvlcedula.Visible = false;
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnMostrarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPacientes.Location = new System.Drawing.Point(12, 28);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(222, 23);
            this.btnMostrarPacientes.TabIndex = 20;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = false;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(252, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(13, 100);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(464, 354);
            this.dgvPacientes.TabIndex = 17;
            // 
            // txtCedP
            // 
            this.txtCedP.Location = new System.Drawing.Point(12, 73);
            this.txtCedP.Name = "txtCedP";
            this.txtCedP.Size = new System.Drawing.Size(225, 20);
            this.txtCedP.TabIndex = 16;
            this.txtCedP.Visible = false;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.btnEliminarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.Location = new System.Drawing.Point(255, 28);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(222, 23);
            this.btnEliminarP.TabIndex = 22;
            this.btnEliminarP.Text = "Eliminar Pacientes";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // PacienteRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.lvlcedula);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtCedP);
            this.Name = "PacienteRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvlcedula;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txtCedP;
        private System.Windows.Forms.Button btnEliminarP;
    }
}