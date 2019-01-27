namespace Registro_Ingreso_Universidad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreVisitante = new System.Windows.Forms.TextBox();
            this.edadVisitante = new System.Windows.Forms.TextBox();
            this.identificacionVisitante = new System.Windows.Forms.TextBox();
            this.motivoVisitante = new System.Windows.Forms.ListBox();
            this.val = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Ingreso visitantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motivo ingreso: ";
            // 
            // nombreVisitante
            // 
            this.nombreVisitante.Location = new System.Drawing.Point(219, 76);
            this.nombreVisitante.Name = "nombreVisitante";
            this.nombreVisitante.Size = new System.Drawing.Size(100, 20);
            this.nombreVisitante.TabIndex = 6;
            this.nombreVisitante.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // edadVisitante
            // 
            this.edadVisitante.Location = new System.Drawing.Point(219, 153);
            this.edadVisitante.Name = "edadVisitante";
            this.edadVisitante.Size = new System.Drawing.Size(100, 20);
            this.edadVisitante.TabIndex = 8;
            // 
            // identificacionVisitante
            // 
            this.identificacionVisitante.Location = new System.Drawing.Point(219, 117);
            this.identificacionVisitante.Name = "identificacionVisitante";
            this.identificacionVisitante.Size = new System.Drawing.Size(100, 20);
            this.identificacionVisitante.TabIndex = 9;
            // 
            // motivoVisitante
            // 
            this.motivoVisitante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoVisitante.FormattingEnabled = true;
            this.motivoVisitante.ItemHeight = 19;
            this.motivoVisitante.Items.AddRange(new object[] {
            "Asesoria",
            "Admisiones",
            "Evento"});
            this.motivoVisitante.Location = new System.Drawing.Point(219, 190);
            this.motivoVisitante.Name = "motivoVisitante";
            this.motivoVisitante.Size = new System.Drawing.Size(100, 23);
            this.motivoVisitante.TabIndex = 11;
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(157, 242);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(75, 23);
            this.val.TabIndex = 0;
            this.val.Text = "Validar";
            this.val.Click += new System.EventHandler(this.val_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 315);
            this.Controls.Add(this.val);
            this.Controls.Add(this.motivoVisitante);
            this.Controls.Add(this.identificacionVisitante);
            this.Controls.Add(this.edadVisitante);
            this.Controls.Add(this.nombreVisitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreVisitante;
        private System.Windows.Forms.TextBox edadVisitante;
        private System.Windows.Forms.TextBox identificacionVisitante;
        private System.Windows.Forms.ListBox motivoVisitante;
        private System.Windows.Forms.Button val;
    }
}