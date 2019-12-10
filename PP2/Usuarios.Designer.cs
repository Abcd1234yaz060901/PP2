namespace PP2
{
    partial class Usuarios
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
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label id_UUsuarioLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LimbiarBoton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.id_UUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            id_UUsuarioLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(26, 167);
            estadoLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(403, 117);
            claveLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 8;
            claveLabel.Text = "Clave:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(403, 68);
            correoLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 7;
            correoLabel.Text = "Correo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 120);
            nombreLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // id_UUsuarioLabel
            // 
            id_UUsuarioLabel.AutoSize = true;
            id_UUsuarioLabel.Location = new System.Drawing.Point(26, 66);
            id_UUsuarioLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            id_UUsuarioLabel.Name = "id_UUsuarioLabel";
            id_UUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            id_UUsuarioLabel.TabIndex = 5;
            id_UUsuarioLabel.Text = "Id Usuario:";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "CREAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LimbiarBoton);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(817, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 554);
            this.panel2.TabIndex = 8;
            // 
            // LimbiarBoton
            // 
            this.LimbiarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimbiarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimbiarBoton.Location = new System.Drawing.Point(25, 350);
            this.LimbiarBoton.Margin = new System.Windows.Forms.Padding(1);
            this.LimbiarBoton.Name = "LimbiarBoton";
            this.LimbiarBoton.Size = new System.Drawing.Size(196, 67);
            this.LimbiarBoton.TabIndex = 9;
            this.LimbiarBoton.Text = "LIMPIAR";
            this.LimbiarBoton.UseVisualStyleBackColor = true;
            this.LimbiarBoton.Click += new System.EventHandler(this.LimbiarBoton_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 246);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.Location = new System.Drawing.Point(102, 163);
            this.estadoCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(169, 23);
            this.estadoCheckBox.TabIndex = 10;
            this.estadoCheckBox.Text = "Activo";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Location = new System.Drawing.Point(10, 244);
            this.usuarioDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.RowHeadersWidth = 102;
            this.usuarioDataGridView.RowTemplate.Height = 40;
            this.usuarioDataGridView.Size = new System.Drawing.Size(601, 316);
            this.usuarioDataGridView.TabIndex = 7;
            this.usuarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuarioDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.estadoCheckBox);
            this.panel1.Controls.Add(claveLabel);
            this.panel1.Controls.Add(this.claveTextBox);
            this.panel1.Controls.Add(correoLabel);
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(id_UUsuarioLabel);
            this.panel1.Controls.Add(this.id_UUsuarioTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 214);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(483, 114);
            this.claveTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(256, 20);
            this.claveTextBox.TabIndex = 9;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(483, 68);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(256, 20);
            this.correoTextBox.TabIndex = 8;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(102, 117);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(182, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // id_UUsuarioTextBox
            // 
            this.id_UUsuarioTextBox.Enabled = false;
            this.id_UUsuarioTextBox.Location = new System.Drawing.Point(102, 66);
            this.id_UUsuarioTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.id_UUsuarioTextBox.Name = "id_UUsuarioTextBox";
            this.id_UUsuarioTextBox.Size = new System.Drawing.Size(182, 20);
            this.id_UUsuarioTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuarios";
            // 
            // Usuarios1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios1";
            this.Text = "Usuarios1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox id_UUsuarioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LimbiarBoton;
    }
}