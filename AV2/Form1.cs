using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2
{
    public partial class Form1 : Form
    {
        public Usuario usuario;  // Instância do usuário atual 
        public Form1()
        {
            InitializeComponent();

            // Configura o DataGridView para mostrar os empréstimos
            dataGridViewEmprestimos.Columns.Add("Titulo", "Título");
            dataGridViewEmprestimos.Columns.Add("Autor", "Autor");
            dataGridViewEmprestimos.Columns.Add("AnoPublicacao", "Ano de Publicação");
            dataGridViewEmprestimos.Columns.Add("Tipo", "Tipo");
            dataGridViewEmprestimos.Columns.Add("InfoAdicional", "Gênero/Edição");
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            var nome = txtNomeUsuario.Text;
            var cpf = txtCpfUsuario.Text;

            // Validação simples para garantir que os campos não estejam vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Por favor, insira um nome e CPF válidos para o usuário.");
                return;
            }

            // Instancia o usuário com as informações fornecidas
            usuario = new Usuario(nome, cpf);
            MessageBox.Show($"Usuário '{usuario.Nome}' salvo com sucesso!");
        }

        private void AtualizarListaEmprestimos()
        {
            if (usuario == null)
            {
                MessageBox.Show("Nenhum usuário registrado. Salve um usuário antes de registrar um empréstimo.");
                return;
            }

            dataGridViewEmprestimos.Rows.Clear(); // Limpa o DataGridView

            // Adiciona as mídias emprestadas ao DataGridView
            foreach (var midia in usuario.MidiasEmprestadas)
            {
                if (midia is Livro livro)
                {
                    dataGridViewEmprestimos.Rows.Add(livro.Titulo, livro.Autor, livro.AnoPublicacao, "Livro", livro.Genero);
                }
                else if (midia is Revista revista)
                {
                    dataGridViewEmprestimos.Rows.Add(revista.Titulo, revista.Autor, revista.AnoPublicacao, "Revista", revista.Edicao.ToString());
                }
            }
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("Nenhum usuário registrado. Salve um usuário antes de registrar um empréstimo.");
                return;
            }

            var titulo = txtTitulo.Text;
            var autor = txtAutor.Text;
            var anoPublicacao = int.Parse(txtAnoPublicacao.Text);
            var genero = txtGenero.Text;

            var livro = new Livro(titulo, autor, anoPublicacao, genero);
            usuario.EmprestarMidia(livro); // Empresta o livro ao usuário

            MessageBox.Show($"Livro '{livro.Titulo}' cadastrado e emprestado com sucesso!");
        }

        private void btnCadastrarRevista_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("Nenhum usuário registrado. Salve um usuário antes de registrar um empréstimo.");
                return;
            }

            var titulo = txtTitulo.Text;
            var autor = txtAutor.Text;
            var anoPublicacao = int.Parse(txtAnoPublicacao.Text);
            var edicao = int.Parse(txtEdicao.Text);

            var revista = new Revista(titulo, autor, anoPublicacao, edicao);
            usuario.EmprestarMidia(revista); // Empresta a revista ao usuário

            MessageBox.Show($"Revista '{revista.Titulo}' cadastrada e emprestada com sucesso!");
        }

        private void btnExibirEmprestimos_Click(object sender, EventArgs e)
        {
            AtualizarListaEmprestimos();
        }
    }
}
