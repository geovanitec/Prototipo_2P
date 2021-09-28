
namespace CapaVista
{
    partial class frmCliente
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
            this.txtestatusCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccionCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txttelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtestatusCliente
            // 
            this.txtestatusCliente.Location = new System.Drawing.Point(275, 404);
            this.txtestatusCliente.Multiline = true;
            this.txtestatusCliente.Name = "txtestatusCliente";
            this.txtestatusCliente.Size = new System.Drawing.Size(191, 34);
            this.txtestatusCliente.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 407);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "ESTATUS";
            // 
            // txtdireccionCliente
            // 
            this.txtdireccionCliente.Location = new System.Drawing.Point(275, 354);
            this.txtdireccionCliente.Multiline = true;
            this.txtdireccionCliente.Name = "txtdireccionCliente";
            this.txtdireccionCliente.Size = new System.Drawing.Size(191, 34);
            this.txtdireccionCliente.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 357);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "DIRECCION RESIDENCIA";
            // 
            // txtcorreoCliente
            // 
            this.txtcorreoCliente.Location = new System.Drawing.Point(275, 301);
            this.txtcorreoCliente.Multiline = true;
            this.txtcorreoCliente.Name = "txtcorreoCliente";
            this.txtcorreoCliente.Size = new System.Drawing.Size(191, 34);
            this.txtcorreoCliente.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 304);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "CORREO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "MANTENIMIENTO CLIENTES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(700, 301);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 34);
            this.txtBuscar.TabIndex = 43;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(593, 301);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 33);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(644, 482);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 46);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(477, 482);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 46);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txttelefonoCliente
            // 
            this.txttelefonoCliente.Location = new System.Drawing.Point(275, 252);
            this.txttelefonoCliente.Multiline = true;
            this.txttelefonoCliente.Name = "txttelefonoCliente";
            this.txttelefonoCliente.Size = new System.Drawing.Size(191, 34);
            this.txttelefonoCliente.TabIndex = 39;
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Location = new System.Drawing.Point(275, 191);
            this.txtnombreCliente.Multiline = true;
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.Size = new System.Drawing.Size(191, 34);
            this.txtnombreCliente.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 255);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "TELEFONO ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "NOMBRE CLIENTE";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(504, 130);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 45;
            this.dgvCliente.Size = new System.Drawing.Size(419, 150);
            this.dgvCliente.TabIndex = 35;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(275, 130);
            this.txtidCliente.Multiline = true;
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(191, 34);
            this.txtidCliente.TabIndex = 34;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(300, 482);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(144, 46);
            this.btnInsertar.TabIndex = 33;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(53, 135);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(73, 13);
            this.ID.TabIndex = 32;
            this.ID.Text = "ID CLIENTE";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 647);
            this.Controls.Add(this.txtestatusCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccionCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcorreoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txttelefonoCliente);
            this.Controls.Add(this.txtnombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.ID);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtestatusCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txttelefonoCliente;
        private System.Windows.Forms.TextBox txtnombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label ID;
    }
}