namespace PPAI.Formularios
{
    partial class FrmMantenimientosRT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientosRT));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRegistrarIngresoRTMP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(128)))));
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnRegistrarIngresoRTMP);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(279, 595);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnRegistrarIngresoRTMP
            // 
            this.btnRegistrarIngresoRTMP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarIngresoRTMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngresoRTMP.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIngresoRTMP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarIngresoRTMP.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarIngresoRTMP.Image")));
            this.btnRegistrarIngresoRTMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarIngresoRTMP.Location = new System.Drawing.Point(3, 221);
            this.btnRegistrarIngresoRTMP.Name = "btnRegistrarIngresoRTMP";
            this.btnRegistrarIngresoRTMP.Size = new System.Drawing.Size(276, 81);
            this.btnRegistrarIngresoRTMP.TabIndex = 0;
            this.btnRegistrarIngresoRTMP.Text = "Registrar Ingreso de RT en Mantenimiento Correctivo";
            this.btnRegistrarIngresoRTMP.UseVisualStyleBackColor = true;
            this.btnRegistrarIngresoRTMP.Click += new System.EventHandler(this.btnRegistrarIngresoRTMP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPAI.Properties.Resources.computadora_1_;
            this.pictureBox1.Location = new System.Drawing.Point(498, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(279, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(711, 100);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Mantenimiento de Recursos Tecnológicos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 100);
            this.panel1.TabIndex = 3;
            // 
            // FrmMantenimientosRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(64)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(990, 595);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientosRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mantenimientos";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRegistrarIngresoRTMP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}