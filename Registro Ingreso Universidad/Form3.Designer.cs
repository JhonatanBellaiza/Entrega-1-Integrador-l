namespace Registro_Ingreso_Universidad
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.validar = new System.Windows.Forms.Button();
            this.codigoComunidad = new System.Windows.Forms.TextBox();
            this.nombreComunidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cargoComunidad = new System.Windows.Forms.ListBox();
            this.reporteComunidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // validar
            // 
            this.validar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar.Location = new System.Drawing.Point(128, 246);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(75, 23);
            this.validar.TabIndex = 21;
            this.validar.Text = "Validar";
            this.validar.UseVisualStyleBackColor = true;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // codigoComunidad
            // 
            this.codigoComunidad.Location = new System.Drawing.Point(219, 146);
            this.codigoComunidad.Name = "codigoComunidad";
            this.codigoComunidad.Size = new System.Drawing.Size(100, 20);
            this.codigoComunidad.TabIndex = 20;
            // 
            // nombreComunidad
            // 
            this.nombreComunidad.Location = new System.Drawing.Point(219, 102);
            this.nombreComunidad.Name = "nombreComunidad";
            this.nombreComunidad.Size = new System.Drawing.Size(100, 20);
            this.nombreComunidad.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cargo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de Ingreso ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Comunidad Universitaria";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cargoComunidad
            // 
            this.cargoComunidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoComunidad.FormattingEnabled = true;
            this.cargoComunidad.ItemHeight = 19;
            this.cargoComunidad.Items.AddRange(new object[] {
            "Estudiante",
            "Empleado",
            "Directivo"});
            this.cargoComunidad.Location = new System.Drawing.Point(219, 190);
            this.cargoComunidad.Name = "cargoComunidad";
            this.cargoComunidad.Size = new System.Drawing.Size(100, 23);
            this.cargoComunidad.TabIndex = 23;
            // 
            // reporteComunidad
            // 
            this.reporteComunidad.Location = new System.Drawing.Point(231, 246);
            this.reporteComunidad.Name = "reporteComunidad";
            this.reporteComunidad.Size = new System.Drawing.Size(75, 23);
            this.reporteComunidad.TabIndex = 24;
            this.reporteComunidad.Text = "Reporte";
            this.reporteComunidad.UseVisualStyleBackColor = true;
            this.reporteComunidad.Click += new System.EventHandler(this.reporteComunidad_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 308);
            this.Controls.Add(this.reporteComunidad);
            this.Controls.Add(this.cargoComunidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.validar);
            this.Controls.Add(this.codigoComunidad);
            this.Controls.Add(this.nombreComunidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.TextBox codigoComunidad;
        private System.Windows.Forms.TextBox nombreComunidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox cargoComunidad;
        private System.Windows.Forms.Button reporteComunidad;
    }
}