namespace capa_presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.consulta = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.est = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.perf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Autenticacion = new System.Windows.Forms.Label();
            this.Aut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(303, 436);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(99, 23);
            this.consulta.TabIndex = 52;
            this.consulta.Text = "Base de datos";
            this.consulta.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(198, 436);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 51;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // est
            // 
            this.est.Location = new System.Drawing.Point(281, 381);
            this.est.Name = "est";
            this.est.Size = new System.Drawing.Size(100, 20);
            this.est.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Estado";
            // 
            // clav
            // 
            this.clav.Location = new System.Drawing.Point(86, 381);
            this.clav.Name = "clav";
            this.clav.Size = new System.Drawing.Size(100, 20);
            this.clav.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Contraseña";
            // 
            // usu
            // 
            this.usu.Location = new System.Drawing.Point(281, 289);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(100, 20);
            this.usu.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Ususario";
            // 
            // perf
            // 
            this.perf.Location = new System.Drawing.Point(86, 289);
            this.perf.Name = "perf";
            this.perf.Size = new System.Drawing.Size(100, 20);
            this.perf.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Perfil";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(281, 206);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "e-mail";
            // 
            // carg
            // 
            this.carg.Location = new System.Drawing.Point(86, 206);
            this.carg.Name = "carg";
            this.carg.Size = new System.Drawing.Size(100, 20);
            this.carg.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cargo";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(281, 127);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "N y A";
            // 
            // nombres
            // 
            this.nombres.Location = new System.Drawing.Point(86, 127);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(100, 20);
            this.nombres.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Iderntificación";
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(281, 59);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 20);
            this.documento.TabIndex = 32;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(418, 102);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(360, 228);
            this.dataGrid.TabIndex = 53;
            // 
            // Autenticacion
            // 
            this.Autenticacion.AutoSize = true;
            this.Autenticacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autenticacion.ForeColor = System.Drawing.Color.Red;
            this.Autenticacion.Location = new System.Drawing.Point(87, 31);
            this.Autenticacion.Name = "Autenticacion";
            this.Autenticacion.Size = new System.Drawing.Size(86, 13);
            this.Autenticacion.TabIndex = 54;
            this.Autenticacion.Text = "AUTENTICAR";
            // 
            // Aut
            // 
            this.Aut.Location = new System.Drawing.Point(86, 59);
            this.Aut.Name = "Aut";
            this.Aut.Size = new System.Drawing.Size(100, 20);
            this.Aut.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 488);
            this.Controls.Add(this.Aut);
            this.Controls.Add(this.Autenticacion);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.est);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.perf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox est;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox clav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox perf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox carg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label Autenticacion;
        private System.Windows.Forms.TextBox Aut;
    }
}

