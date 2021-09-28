
namespace CapaVista
{
    partial class Contenedor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hABITACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERRAMIENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.cATALOGOSToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.hERRAMIENTASToolStripMenuItem,
            this.aYUDASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hABITACIONToolStripMenuItem,
            this.cLIENTEToolStripMenuItem});
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // hABITACIONToolStripMenuItem
            // 
            this.hABITACIONToolStripMenuItem.Name = "hABITACIONToolStripMenuItem";
            this.hABITACIONToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.hABITACIONToolStripMenuItem.Text = "HABITACION";
            this.hABITACIONToolStripMenuItem.Click += new System.EventHandler(this.hABITACIONToolStripMenuItem_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESERVACIONToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // rESERVACIONToolStripMenuItem
            // 
            this.rESERVACIONToolStripMenuItem.Name = "rESERVACIONToolStripMenuItem";
            this.rESERVACIONToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.rESERVACIONToolStripMenuItem.Text = "RESERVACION";
            this.rESERVACIONToolStripMenuItem.Click += new System.EventHandler(this.rESERVACIONToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // hERRAMIENTASToolStripMenuItem
            // 
            this.hERRAMIENTASToolStripMenuItem.Name = "hERRAMIENTASToolStripMenuItem";
            this.hERRAMIENTASToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
            this.hERRAMIENTASToolStripMenuItem.Text = "HERRAMIENTAS";
            // 
            // aYUDASToolStripMenuItem
            // 
            this.aYUDASToolStripMenuItem.Name = "aYUDASToolStripMenuItem";
            this.aYUDASToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.aYUDASToolStripMenuItem.Text = "AYUDAS";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 538);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor_GeovaniMendoza";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hABITACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESERVACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERRAMIENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDASToolStripMenuItem;
    }
}