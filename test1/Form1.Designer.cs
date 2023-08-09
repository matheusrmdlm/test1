namespace test1
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
            this.tab1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.AutoSize = true;
            this.tab1.Location = new System.Drawing.Point(388, 9);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(35, 13);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Nome";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(391, 25);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(128, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tab2
            // 
            this.tab2.AutoSize = true;
            this.tab2.Location = new System.Drawing.Point(391, 52);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(32, 13);
            this.tab2.TabIndex = 3;
            this.tab2.Text = "Email";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(391, 68);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(128, 20);
            this.txt2.TabIndex = 4;
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(525, 25);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 63);
            this.btn.TabIndex = 5;
            this.btn.Text = "Confirmar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test1.Properties.Resources.urubu_do_pix_e_novo_golpe_na_praca_1657379024808_v2_615x300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(613, 299);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tab1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label tab2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn;
    }
}

