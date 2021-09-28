
namespace CapaVista
{
    partial class frmReservacion
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
            this.txtfechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservacion = new System.Windows.Forms.DataGridView();
            this.txtidReservacion = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfechaFinal
            // 
            this.txtfechaFinal.Location = new System.Drawing.Point(290, 361);
            this.txtfechaFinal.Name = "txtfechaFinal";
            this.txtfechaFinal.Size = new System.Drawing.Size(201, 20);
            this.txtfechaFinal.TabIndex = 78;
            // 
            // txtestatus
            // 
            this.txtestatus.Location = new System.Drawing.Point(290, 413);
            this.txtestatus.Multiline = true;
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(191, 34);
            this.txtestatus.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 416);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "ESTATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 366);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "FECHA FIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 313);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "FECHA INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 73;
            this.label3.Text = "RESERVACION";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(715, 310);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 34);
            this.txtBuscar.TabIndex = 72;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(608, 310);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 33);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(659, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 46);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(492, 491);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 46);
            this.btnModificar.TabIndex = 69;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 264);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "ID HABITACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID CLIENTE";
            // 
            // dgvReservacion
            // 
            this.dgvReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservacion.Location = new System.Drawing.Point(519, 139);
            this.dgvReservacion.Name = "dgvReservacion";
            this.dgvReservacion.RowHeadersWidth = 45;
            this.dgvReservacion.Size = new System.Drawing.Size(419, 150);
            this.dgvReservacion.TabIndex = 66;
            this.dgvReservacion.SelectionChanged += new System.EventHandler(this.dgvReservacion_SelectionChanged);
            // 
            // txtidReservacion
            // 
            this.txtidReservacion.Location = new System.Drawing.Point(290, 139);
            this.txtidReservacion.Multiline = true;
            this.txtidReservacion.Name = "txtidReservacion";
            this.txtidReservacion.Size = new System.Drawing.Size(191, 34);
            this.txtidReservacion.TabIndex = 65;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(315, 491);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(144, 46);
            this.btnInsertar.TabIndex = 64;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(68, 144);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(107, 15);
            this.ID.TabIndex = 63;
            this.ID.Text = "ID RESERVACION";
            // 
            // txtfechaInicio
            // 
            this.txtfechaInicio.Location = new System.Drawing.Point(290, 323);
            this.txtfechaInicio.Name = "txtfechaInicio";
            this.txtfechaInicio.Size = new System.Drawing.Size(201, 20);
            this.txtfechaInicio.TabIndex = 61;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(290, 200);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(191, 34);
            this.txtIdCliente.TabIndex = 80;
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Location = new System.Drawing.Point(290, 255);
            this.txtIdHabitacion.Multiline = true;
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(191, 34);
            this.txtIdHabitacion.TabIndex = 81;
            // 
            // frmReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 585);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtfechaFinal);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservacion);
            this.Controls.Add(this.txtidReservacion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtfechaInicio);
            this.Name = "frmReservacion";
            this.Text = "Reservacion";
            this.Load += new System.EventHandler(this.frmReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtfechaFinal;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservacion;
        private System.Windows.Forms.TextBox txtidReservacion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.DateTimePicker txtfechaInicio;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdHabitacion;
    }
}