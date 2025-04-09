namespace AV2
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
            this.InformacoesDoUsuario = new System.Windows.Forms.GroupBox();
            this.txtCpfUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.CadastroDeMidia = new System.Windows.Forms.GroupBox();
            this.btnCadastrarRevista = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEmprestimos = new System.Windows.Forms.DataGridView();
            this.btnExibirEmprestimos = new System.Windows.Forms.Button();
            this.InformacoesDoUsuario.SuspendLayout();
            this.CadastroDeMidia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // InformacoesDoUsuario
            // 
            this.InformacoesDoUsuario.Controls.Add(this.txtCpfUsuario);
            this.InformacoesDoUsuario.Controls.Add(this.txtNomeUsuario);
            this.InformacoesDoUsuario.Controls.Add(this.label2);
            this.InformacoesDoUsuario.Controls.Add(this.label1);
            this.InformacoesDoUsuario.Controls.Add(this.btnSalvarUsuario);
            this.InformacoesDoUsuario.Location = new System.Drawing.Point(21, 25);
            this.InformacoesDoUsuario.Name = "InformacoesDoUsuario";
            this.InformacoesDoUsuario.Size = new System.Drawing.Size(333, 158);
            this.InformacoesDoUsuario.TabIndex = 0;
            this.InformacoesDoUsuario.TabStop = false;
            this.InformacoesDoUsuario.Text = "Informações do Usuário";
            // 
            // txtCpfUsuario
            // 
            this.txtCpfUsuario.Location = new System.Drawing.Point(69, 61);
            this.txtCpfUsuario.Name = "txtCpfUsuario";
            this.txtCpfUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtCpfUsuario.TabIndex = 4;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(69, 35);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(9, 106);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(94, 23);
            this.btnSalvarUsuario.TabIndex = 0;
            this.btnSalvarUsuario.Text = "Salvar Usuário";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // CadastroDeMidia
            // 
            this.CadastroDeMidia.Controls.Add(this.btnCadastrarRevista);
            this.CadastroDeMidia.Controls.Add(this.btnCadastrarLivro);
            this.CadastroDeMidia.Controls.Add(this.txtEdicao);
            this.CadastroDeMidia.Controls.Add(this.txtGenero);
            this.CadastroDeMidia.Controls.Add(this.txtAnoPublicacao);
            this.CadastroDeMidia.Controls.Add(this.txtAutor);
            this.CadastroDeMidia.Controls.Add(this.txtTitulo);
            this.CadastroDeMidia.Controls.Add(this.label7);
            this.CadastroDeMidia.Controls.Add(this.label6);
            this.CadastroDeMidia.Controls.Add(this.label5);
            this.CadastroDeMidia.Controls.Add(this.label4);
            this.CadastroDeMidia.Controls.Add(this.label3);
            this.CadastroDeMidia.Location = new System.Drawing.Point(21, 212);
            this.CadastroDeMidia.Name = "CadastroDeMidia";
            this.CadastroDeMidia.Size = new System.Drawing.Size(333, 181);
            this.CadastroDeMidia.TabIndex = 1;
            this.CadastroDeMidia.TabStop = false;
            this.CadastroDeMidia.Text = "Cadastro de Mídia";
            // 
            // btnCadastrarRevista
            // 
            this.btnCadastrarRevista.Location = new System.Drawing.Point(222, 96);
            this.btnCadastrarRevista.Name = "btnCadastrarRevista";
            this.btnCadastrarRevista.Size = new System.Drawing.Size(105, 23);
            this.btnCadastrarRevista.TabIndex = 11;
            this.btnCadastrarRevista.Text = "Cadastrar Revista";
            this.btnCadastrarRevista.UseVisualStyleBackColor = true;
            this.btnCadastrarRevista.Click += new System.EventHandler(this.btnCadastrarRevista_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(222, 67);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(105, 23);
            this.btnCadastrarLivro.TabIndex = 10;
            this.btnCadastrarLivro.Text = "Cadastrar Livro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(51, 142);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(165, 20);
            this.txtEdicao.TabIndex = 9;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(51, 112);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(165, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(112, 84);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(104, 20);
            this.txtAnoPublicacao.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(51, 55);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(165, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(51, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(165, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ano de Publicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Título";
            // 
            // dataGridViewEmprestimos
            // 
            this.dataGridViewEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimos.Location = new System.Drawing.Point(375, 25);
            this.dataGridViewEmprestimos.Name = "dataGridViewEmprestimos";
            this.dataGridViewEmprestimos.Size = new System.Drawing.Size(395, 368);
            this.dataGridViewEmprestimos.TabIndex = 2;
            // 
            // btnExibirEmprestimos
            // 
            this.btnExibirEmprestimos.Location = new System.Drawing.Point(375, 400);
            this.btnExibirEmprestimos.Name = "btnExibirEmprestimos";
            this.btnExibirEmprestimos.Size = new System.Drawing.Size(121, 23);
            this.btnExibirEmprestimos.TabIndex = 3;
            this.btnExibirEmprestimos.Text = "Exibir Empréstimos";
            this.btnExibirEmprestimos.UseVisualStyleBackColor = true;
            this.btnExibirEmprestimos.Click += new System.EventHandler(this.btnExibirEmprestimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibirEmprestimos);
            this.Controls.Add(this.dataGridViewEmprestimos);
            this.Controls.Add(this.CadastroDeMidia);
            this.Controls.Add(this.InformacoesDoUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InformacoesDoUsuario.ResumeLayout(false);
            this.InformacoesDoUsuario.PerformLayout();
            this.CadastroDeMidia.ResumeLayout(false);
            this.CadastroDeMidia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InformacoesDoUsuario;
        private System.Windows.Forms.TextBox txtCpfUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.GroupBox CadastroDeMidia;
        private System.Windows.Forms.Button btnCadastrarRevista;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimos;
        private System.Windows.Forms.Button btnExibirEmprestimos;
    }
}

