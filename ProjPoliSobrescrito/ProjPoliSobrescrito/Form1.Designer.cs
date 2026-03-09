namespace ProjPoliSobrescrito
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
            this.btnSobrescrito = new System.Windows.Forms.Button();
            this.btnSobrescrita2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSobrescrito
            // 
            this.btnSobrescrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobrescrito.Location = new System.Drawing.Point(60, 33);
            this.btnSobrescrito.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSobrescrito.Name = "btnSobrescrito";
            this.btnSobrescrito.Size = new System.Drawing.Size(294, 150);
            this.btnSobrescrito.TabIndex = 0;
            this.btnSobrescrito.Text = "Sobrescrito";
            this.btnSobrescrito.UseVisualStyleBackColor = true;
            this.btnSobrescrito.Click += new System.EventHandler(this.btnSobrescrito_Click);
            // 
            // btnSobrescrita2
            // 
            this.btnSobrescrita2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobrescrita2.Location = new System.Drawing.Point(390, 33);
            this.btnSobrescrita2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSobrescrita2.Name = "btnSobrescrita2";
            this.btnSobrescrita2.Size = new System.Drawing.Size(287, 150);
            this.btnSobrescrita2.TabIndex = 1;
            this.btnSobrescrita2.Text = "Sobrescrito 2";
            this.btnSobrescrita2.UseVisualStyleBackColor = true;
            this.btnSobrescrita2.Click += new System.EventHandler(this.btnSobrescrita2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 428);
            this.Controls.Add(this.btnSobrescrita2);
            this.Controls.Add(this.btnSobrescrito);
            this.Margin = new System.Windows.Forms.Padding(28, 22, 28, 22);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSobrescrito;
        private System.Windows.Forms.Button btnSobrescrita2;
    }
}

