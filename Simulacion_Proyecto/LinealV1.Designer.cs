namespace Simulacion_Proyecto
{
    partial class LinealV1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estado = new System.Windows.Forms.Label();
            this.tbIteraciones = new System.Windows.Forms.TextBox();
            this.lbIteraciones = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.lbM = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.tbX0 = new System.Windows.Forms.TextBox();
            this.lbX0 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarT = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tablas = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aXnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.tbIteraciones);
            this.groupBox1.Controls.Add(this.lbIteraciones);
            this.groupBox1.Controls.Add(this.tbM);
            this.groupBox1.Controls.Add(this.lbM);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.lbC);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Controls.Add(this.lbA);
            this.groupBox1.Controls.Add(this.tbX0);
            this.groupBox1.Controls.Add(this.lbX0);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 181);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar datos";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(11, 203);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(0, 19);
            this.estado.TabIndex = 37;
            // 
            // tbIteraciones
            // 
            this.tbIteraciones.Location = new System.Drawing.Point(218, 24);
            this.tbIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbIteraciones.Name = "tbIteraciones";
            this.tbIteraciones.Size = new System.Drawing.Size(76, 26);
            this.tbIteraciones.TabIndex = 5;
            // 
            // lbIteraciones
            // 
            this.lbIteraciones.AutoSize = true;
            this.lbIteraciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIteraciones.Location = new System.Drawing.Point(185, 27);
            this.lbIteraciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIteraciones.Name = "lbIteraciones";
            this.lbIteraciones.Size = new System.Drawing.Size(36, 19);
            this.lbIteraciones.TabIndex = 36;
            this.lbIteraciones.Text = "I =";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(78, 142);
            this.tbM.Margin = new System.Windows.Forms.Padding(2);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(76, 26);
            this.tbM.TabIndex = 4;
            this.tbM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbM_KeyPress_1);
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.Location = new System.Drawing.Point(27, 134);
            this.lbM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(36, 19);
            this.lbM.TabIndex = 34;
            this.lbM.Text = "m =";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(78, 99);
            this.tbC.Margin = new System.Windows.Forms.Padding(2);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(76, 26);
            this.tbC.TabIndex = 3;
            this.tbC.TextChanged += new System.EventHandler(this.tbC_TextChanged);
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress_1);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(27, 95);
            this.lbC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(36, 19);
            this.lbC.TabIndex = 32;
            this.lbC.Text = "c =";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(78, 59);
            this.tbA.Margin = new System.Windows.Forms.Padding(2);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(76, 26);
            this.tbA.TabIndex = 2;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress_1);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(27, 60);
            this.lbA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(36, 19);
            this.lbA.TabIndex = 30;
            this.lbA.Text = "a =";
            // 
            // tbX0
            // 
            this.tbX0.Location = new System.Drawing.Point(78, 24);
            this.tbX0.Margin = new System.Windows.Forms.Padding(2);
            this.tbX0.Name = "tbX0";
            this.tbX0.Size = new System.Drawing.Size(76, 26);
            this.tbX0.TabIndex = 1;
            this.tbX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbX0_KeyPress_1);
            // 
            // lbX0
            // 
            this.lbX0.AutoSize = true;
            this.lbX0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX0.Location = new System.Drawing.Point(11, 24);
            this.lbX0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbX0.Name = "lbX0";
            this.lbX0.Size = new System.Drawing.Size(63, 19);
            this.lbX0.TabIndex = 28;
            this.lbX0.Text = "X(n) =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnHabilitar);
            this.groupBox2.Controls.Add(this.btnAuto);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnLimpiarT);
            this.groupBox2.Controls.Add(this.btLimpiar);
            this.groupBox2.Controls.Add(this.btCalcular);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(675, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 273);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(6, 177);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(155, 45);
            this.btnHabilitar.TabIndex = 31;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(6, 57);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(255, 34);
            this.btnAuto.TabIndex = 30;
            this.btnAuto.Text = "Generar automatico";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Simulacion_Proyecto.Properties.Resources._13964;
            this.pictureBox1.Location = new System.Drawing.Point(200, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Presiona la imagen para ir al menu principal";
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnLimpiarT
            // 
            this.btnLimpiarT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarT.Location = new System.Drawing.Point(6, 140);
            this.btnLimpiarT.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarT.Name = "btnLimpiarT";
            this.btnLimpiarT.Size = new System.Drawing.Size(255, 32);
            this.btnLimpiarT.TabIndex = 29;
            this.btnLimpiarT.Text = "Limpiar T";
            this.btnLimpiarT.UseVisualStyleBackColor = true;
            this.btnLimpiarT.Click += new System.EventHandler(this.btnLimpiarT_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(6, 99);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(255, 32);
            this.btLimpiar.TabIndex = 27;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click_1);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(5, 20);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(257, 32);
            this.btCalcular.TabIndex = 26;
            this.btCalcular.Text = "Calcular y guardar";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tablas);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 165);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados obtenidos";
            // 
            // tablas
            // 
            this.tablas.AllowUserToAddRows = false;
            this.tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Xn,
            this.aXnc,
            this.modM,
            this.Column1});
            this.tablas.Location = new System.Drawing.Point(8, 25);
            this.tablas.Margin = new System.Windows.Forms.Padding(2);
            this.tablas.Name = "tablas";
            this.tablas.RowHeadersWidth = 51;
            this.tablas.Size = new System.Drawing.Size(655, 122);
            this.tablas.TabIndex = 15;
            // 
            // i
            // 
            this.i.HeaderText = "Iteraciones";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 125;
            // 
            // Xn
            // 
            this.Xn.HeaderText = "X(n)";
            this.Xn.MinimumWidth = 6;
            this.Xn.Name = "Xn";
            this.Xn.Width = 125;
            // 
            // aXnc
            // 
            this.aXnc.HeaderText = "a*X(n)+c";
            this.aXnc.MinimumWidth = 6;
            this.aXnc.Name = "aXnc";
            this.aXnc.Width = 125;
            // 
            // modM
            // 
            this.modM.HeaderText = "[a*X(n)+c] mod m ";
            this.modM.MinimumWidth = 6;
            this.modM.Name = "modM";
            this.modM.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xi";
            this.Column1.Name = "Column1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 228);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(255, 32);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // LinealV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LinealV1";
            this.Text = "LinealV1";
            this.Load += new System.EventHandler(this.LinealV1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIteraciones;
        private System.Windows.Forms.Label lbIteraciones;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox tbX0;
        private System.Windows.Forms.Label lbX0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btnLimpiarT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aXnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn modM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnEliminar;
    }
}