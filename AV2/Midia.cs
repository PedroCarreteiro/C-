using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2
{
    public class Midia
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get; private set; }

        public Midia(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nAno de Publicação: {AnoPublicacao}");
        }
    }

}
