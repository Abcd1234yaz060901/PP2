namespace PP2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components1 = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components1 != null))
            {
                components1.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelformularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BotonUsuarios = new System.Windows.Forms.Button();
            this.BotonPrestamos = new System.Windows.Forms.Button();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelformularios.Controls.Add(this.pictureBox1);
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(188, 32);
            this.panelformularios.Margin = new System.Windows.Forms.Padding(2);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(1071, 662);
            this.panelformularios.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1154, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.BotonUsuarios);
            this.panelMenu.Controls.Add(this.BotonPrestamos);
            this.panelMenu.Controls.Add(this.BotonClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 662);
            this.panelMenu.TabIndex = 7;
            // 
            // BotonUsuarios
            // 
            this.BotonUsuarios.FlatAppearance.BorderSize = 0;
            this.BotonUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BotonUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BotonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.BotonUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BotonUsuarios.Image")));
            this.BotonUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonUsuarios.Location = new System.Drawing.Point(0, 106);
            this.BotonUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BotonUsuarios.Name = "BotonUsuarios";
            this.BotonUsuarios.Size = new System.Drawing.Size(188, 40);
            this.BotonUsuarios.TabIndex = 3;
            this.BotonUsuarios.Text = "USUARIOS";
            this.BotonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonUsuarios.UseVisualStyleBackColor = true;
            this.BotonUsuarios.Click += new System.EventHandler(this.BotonUsuarios_Click_1);
            // 
            // BotonPrestamos
            // 
            this.BotonPrestamos.FlatAppearance.BorderSize = 0;
            this.BotonPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BotonPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BotonPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPrestamos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BotonPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("BotonPrestamos.Image")));
            this.BotonPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonPrestamos.Location = new System.Drawing.Point(-2, 480);
            this.BotonPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.BotonPrestamos.Name = "BotonPrestamos";
            this.BotonPrestamos.Size = new System.Drawing.Size(188, 40);
            this.BotonPrestamos.TabIndex = 2;
            this.BotonPrestamos.Text = "PRESTAMOS";
            this.BotonPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonPrestamos.UseVisualStyleBackColor = true;
            this.BotonPrestamos.Click += new System.EventHandler(this.BotonPrestamos_Click_1);
            // 
            // BotonClientes
            // 
            this.BotonClientes.FlatAppearance.BorderSize = 0;
            this.BotonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BotonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BotonClientes.Image = ((System.Drawing.Image)(resources.GetObject("BotonClientes.Image")));
            this.BotonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonClientes.Location = new System.Drawing.Point(2, 278);
            this.BotonClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.Size = new System.Drawing.Size(188, 40);
            this.BotonClientes.TabIndex = 1;
            this.BotonClientes.Text = "CLIENTES";
            this.BotonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonClientes.UseVisualStyleBackColor = true;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click_1);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.AutoSize = true;
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.label1);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1259, 32);
            this.panelBarraTitulo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUANDO VENCES TUS MIEDOS SE DESTRUYEN TUS LIMITES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 694);
            this.Controls.Add(this.panelformularios);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarraTitulo);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelformularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BotonUsuarios;
        private System.Windows.Forms.Button BotonPrestamos;
        private System.Windows.Forms.Button BotonClientes;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label label1;
    }
}