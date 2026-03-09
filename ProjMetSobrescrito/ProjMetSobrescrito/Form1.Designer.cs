namespace ProjMetSobrescrito
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
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnSaqueEspecial = new System.Windows.Forms.Button();
            this.btnDdos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(103, 247);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(249, 69);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(126, 169);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(193, 72);
            this.btnSaque.TabIndex = 1;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnSaqueEspecial
            // 
            this.btnSaqueEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaqueEspecial.Location = new System.Drawing.Point(422, 169);
            this.btnSaqueEspecial.Name = "btnSaqueEspecial";
            this.btnSaqueEspecial.Size = new System.Drawing.Size(256, 141);
            this.btnSaqueEspecial.TabIndex = 2;
            this.btnSaqueEspecial.Text = "Saque Especial";
            this.btnSaqueEspecial.UseVisualStyleBackColor = true;
            this.btnSaqueEspecial.Click += new System.EventHandler(this.btnSaqueEspecial_Click);
            // 
            // btnDdos
            // 
            this.btnDdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDdos.Location = new System.Drawing.Point(268, 48);
            this.btnDdos.Name = "btnDdos";
            this.btnDdos.Size = new System.Drawing.Size(249, 69);
            this.btnDdos.TabIndex = 3;
            this.btnDdos.Text = "Dados";
            this.btnDdos.UseVisualStyleBackColor = true;
            this.btnDdos.Click += new System.EventHandler(this.btnDdos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDdos);
            this.Controls.Add(this.btnSaqueEspecial);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDeposito);
            this.Name = "Form1";
            this.Text = "ui2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnSaqueEspecial;
        private System.Windows.Forms.Button btnDdos;
    }
}

