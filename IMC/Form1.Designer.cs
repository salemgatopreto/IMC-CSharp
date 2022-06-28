namespace IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.textimc = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.AutoSize = true;
            this.txtPeso.Location = new System.Drawing.Point(71, 97);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(31, 13);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.Text = "Peso";
            this.txtPeso.Click += new System.EventHandler(this.txtPeso_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.AutoSize = true;
            this.txtAltura.Location = new System.Drawing.Point(71, 138);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(34, 13);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Text = "Altura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtIMC
            // 
            this.txtIMC.AutoSize = true;
            this.txtIMC.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(23, 28);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(263, 26);
            this.txtIMC.TabIndex = 4;
            this.txtIMC.Text = "CALCULE SEU IMC ";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(86, 190);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // textimc
            // 
            this.textimc.AutoSize = true;
            this.textimc.Location = new System.Drawing.Point(74, 229);
            this.textimc.Name = "textimc";
            this.textimc.Size = new System.Drawing.Size(26, 13);
            this.textimc.TabIndex = 6;
            this.textimc.Text = "IMC";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(301, 398);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textimc);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPeso;
        private System.Windows.Forms.Label txtAltura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtIMC;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label textimc;
        private System.Windows.Forms.TextBox textBox3;
    }
}

