
namespace CapaVista
{
    partial class frmHabitacion
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtestadoHabitacion = new System.Windows.Forms.TextBox();
            this.txttamañoHabitacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHabitacion = new System.Windows.Forms.DataGridView();
            this.txtidHabitacion = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "MANTENIMIENTO HABITACION";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(678, 303);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 34);
            this.txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(571, 303);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 33);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(409, 381);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 46);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(242, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 46);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtestadoHabitacion
            // 
            this.txtestadoHabitacion.Location = new System.Drawing.Point(253, 254);
            this.txtestadoHabitacion.Multiline = true;
            this.txtestadoHabitacion.Name = "txtestadoHabitacion";
            this.txtestadoHabitacion.Size = new System.Drawing.Size(191, 34);
            this.txtestadoHabitacion.TabIndex = 20;
            // 
            // txttamañoHabitacion
            // 
            this.txttamañoHabitacion.Location = new System.Drawing.Point(253, 193);
            this.txttamañoHabitacion.Multiline = true;
            this.txttamañoHabitacion.Name = "txttamañoHabitacion";
            this.txttamañoHabitacion.Size = new System.Drawing.Size(191, 34);
            this.txttamañoHabitacion.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "ESTADO HABITACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "TAMAÑO HABITACION";
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Location = new System.Drawing.Point(482, 132);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.RowHeadersWidth = 45;
            this.dgvHabitacion.Size = new System.Drawing.Size(419, 150);
            this.dgvHabitacion.TabIndex = 16;
            this.dgvHabitacion.SelectionChanged += new System.EventHandler(this.dgvHabitacion_SelectionChanged);
            // 
            // txtidHabitacion
            // 
            this.txtidHabitacion.Location = new System.Drawing.Point(253, 132);
            this.txtidHabitacion.Multiline = true;
            this.txtidHabitacion.Name = "txtidHabitacion";
            this.txtidHabitacion.Size = new System.Drawing.Size(191, 34);
            this.txtidHabitacion.TabIndex = 15;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(65, 381);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(144, 46);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(31, 137);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(92, 15);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID HABITACION";
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtestadoHabitacion);
            this.Controls.Add(this.txttamañoHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHabitacion);
            this.Controls.Add(this.txtidHabitacion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.ID);
            this.Name = "frmHabitacion";
            this.Text = "Habitacion";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtestadoHabitacion;
        private System.Windows.Forms.TextBox txttamañoHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHabitacion;
        private System.Windows.Forms.TextBox txtidHabitacion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label ID;
    }
}