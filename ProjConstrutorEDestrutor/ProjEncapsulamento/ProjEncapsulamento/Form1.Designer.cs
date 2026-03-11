namespace ProjEncapsulamento
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConstrutor = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(32, 41);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(109, 54);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnErro
            // 
            this.btnErro.Location = new System.Drawing.Point(147, 41);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(109, 54);
            this.btnErro.TabIndex = 1;
            this.btnErro.Text = "Tratamento de erro";
            this.btnErro.UseVisualStyleBackColor = true;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(262, 41);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(109, 54);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(377, 41);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(109, 54);
            this.btnMetodo.TabIndex = 3;
            this.btnMetodo.Text = "Método";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Location = new System.Drawing.Point(492, 41);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(109, 54);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnConstrutor
            // 
            this.btnConstrutor.Location = new System.Drawing.Point(32, 117);
            this.btnConstrutor.Name = "btnConstrutor";
            this.btnConstrutor.Size = new System.Drawing.Size(109, 54);
            this.btnConstrutor.TabIndex = 6;
            this.btnConstrutor.Text = "Construtor";
            this.btnConstrutor.UseVisualStyleBackColor = true;
            this.btnConstrutor.Click += new System.EventHandler(this.btnConstrutor_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(147, 117);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(109, 54);
            this.btnProduto.TabIndex = 7;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(622, 419);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnConstrutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnErro);
            this.Controls.Add(this.btnUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConstrutor;
        private System.Windows.Forms.Button btnProduto;
    }
}

